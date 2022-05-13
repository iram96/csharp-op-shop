namespace test
{
    //Extension methods are defined as static methods but are called by
    //using instance method syntax.Their first parameter specifies which
    //type the method operates on.The parameter is preceded by the this
    //modifier.Extension methods are only in scope when you explicitly
    //import the namespace into your source code with a using directive.
    public static class rova
    {
        public static int WordCount(this string inputString)
        {
            //La Split delle stringhe è un'istruzione molto potente per spezzettare una stringa in elementi più piccoli (sottostringhe)
            return inputString.Split(new char[] { ' ', '.', ';' /* ... */ },
StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}