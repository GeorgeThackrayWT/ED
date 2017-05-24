using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MvvmHelpers;
using SQLite.Net;
using SQLite.Net.Attributes;
using WTSqLExt.Attributes;
using WTSqLExt.Extensions;
using WTSqLExtAsync.Extensions;

namespace SQLiteNetExtensionsAsync.Extensions
{
    public class WtDataObject<T> : ObservableObject where T : class, new()
    {

        public WtDataObject()
        {
        //    Debug.WriteLine("BaseEntity constructor");
        }

        public virtual int ID { get; set; }


        [Ignore]
        [ConnectionAttribute]
        public SQLiteConnectionWithLock Connection { get; set; }


    }

    public static class TestExt
    {

        public static T GetIFNull<T>(this WtDataObject<T> t) where T : class, new()
        {

            object temp = (object)t;// cast(t).ID;


            var r = temp.GetType().GetPrimaryKey();

            var foreignKeyData = temp.GetType().GetRelationshipProperties().FirstOrDefault();


            // is this data already present?
            object fkeyDatVal = null;

            if (foreignKeyData != null)
            {
            
                fkeyDatVal = foreignKeyData.GetValue(temp, null);

                if (fkeyDatVal == null)
                {                    
                    var foreignKeyVal = r.GetValue(temp, null);

                    var connection = (WtDataObject<T>)temp;

                    var relationObj = connection.Connection.GetWithChildren<T>(foreignKeyVal);

                    //  var tp = t.GetType().get;

                //    var tempProps = temp.GetType().GetRelationshipProperties();

                    //Debug.WriteLine("temp props");
                    foreach (var v in temp.GetType().GetRelationshipProperties())
                    {
                        //tempProps.FirstOrDefault(p=>p.Name)

                      //  Debug.WriteLine(v.Name + " -b " + v.GetValue(temp, null));

                      //  Debug.WriteLine(v.Name + " -r " + v.GetValue(relationObj, null));

                        v.SetValue(temp, v.GetValue(relationObj, null));
                    }

                    //Debug.WriteLine("retrieved props");
                    //foreach (var v in relationObj.GetType().GetRelationshipProperties())
                    //{
                    //    //tempProps.FirstOrDefault(p=>p.Name)

                    //    Debug.WriteLine(v.Name + " " + v.GetValue(relationObj, null));

                         
                    //}




                    //  this = relationObj;

                    return relationObj;
                }                
            }

            


            //GetWithChildrenAsync<T>(x);
            return (T)temp;
        }

    }


}
