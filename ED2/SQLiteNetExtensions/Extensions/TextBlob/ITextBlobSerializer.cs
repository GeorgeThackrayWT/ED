using System;

namespace WTSqLExt.Extensions.TextBlob
{
    public interface ITextBlobSerializer
    {
        string Serialize(object element);
        object Deserialize(string text, Type type);
    }
}