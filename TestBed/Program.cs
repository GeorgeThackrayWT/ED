using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abstractions;
using SQLite.Net.Interop;
using SQLite.Net.Platform.Win32;
using Stores;
using TinyIoC;
//using SQLite.Net.Platform.Win32;
//using SQLite.Net.Platform.Generic;


namespace TestBed
{
    public class TestPlatform : Abstractions.IPlatform
    {

        public string GetFilePath()
        {

            return System.IO.Path.Combine(@"C:\Users\gth\AppData\Local\Packages\ef791dcc-cce5-4636-afff-fda47c6f5d94_06pd8rmtn56te\LocalState\", "estate.sqlite3");
        }

        public ISQLitePlatform GetPlatform()
        {
            // return null;
            return new SQLitePlatformWin32();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testing");


            TinyIoCContainer.Current.Register<IPlatform, TestPlatform>();

            TinyIoCContainer.Current.Register<ITaskStore, TaskStore>();

            TinyIoCContainer.Current.Register<IMenuStore, MenuStore>();

            //  TinyIoCContainer.Current.Register<ITaskListViewModel, TaskListViewModel>();

            Console.WriteLine(DateTime.Now.ToShortTimeString());

            //     var tlvm = TinyIoCContainer.Current.Resolve<TaskListViewModel>();

            var menuStore = TinyIoCContainer.Current.Resolve<IMenuStore>();

            var taskStore = TinyIoCContainer.Current.Resolve<ITaskStore>();

        //    var test = menuStore.CreateMenusAsynch();

            //        var test = menuStore.GetMenusAsync();
 


            var test2 = menuStore.TableExists("Menu");

            test2.Wait();

            if (test2.Result != "Menu")
            {
                menuStore.CreateMenusAsynch().Wait();


            }

            menuStore.AddMenuData().Wait();



            Console.WriteLine(test2.Result);

            Console.WriteLine(DateTime.Now.ToShortTimeString());

            // Console.WriteLine(test.Result.Count());

            Console.ReadLine();

        }
    }
}

