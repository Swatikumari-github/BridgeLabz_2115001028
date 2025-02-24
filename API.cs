using System;


namespace AnnotationReflection
{
    
    class LegacyAPI
    {
        [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.")]
        public void OldFeature()
        {
            Console.WriteLine("This is an old feature and should not be used.");
        }

        public void NewFeature()
        {
            Console.WriteLine("This is the new and improved feature.");
        }
    }

    class API
    {
        static void Main()
        {
            LegacyAPI legacyApi = new LegacyAPI();  // Changed variable name to legacyApi

            legacyApi.OldFeature();  // This will show a warning
            legacyApi.NewFeature();  // This is the recommended method
        }
    }

}
