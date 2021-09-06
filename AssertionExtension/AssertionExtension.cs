using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTestProjectLP.AssertionExtension
{
    public static class AssertionExtension
    {

        public static void IsOfType<T>(this Assert assert, object obj)
        {
            if (obj is T)
            {
                return;
            }
            throw new AssertFailedException("Type does not match");

        }
    }
}
