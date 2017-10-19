using System;

namespace PDF_Report
{
    public class TagInfoTest
    {
        public TestType2Report TestType { get; set; }
        public TestClass2Export TestClass { get; set; }
        public override string ToString()
        {
            switch ( TestType )
            {
                case TestType2Report.Imagenes:
                    return ( this.TestClass == TestClass2Export.Simple )
                               ? "Atención Sostenida 1, Imágenes"
                               : "Atención Sostenida 2, Imágenes";
                case TestType2Report.Figuras:
                    return (this.TestClass == TestClass2Export.Simple)
                               ? "Atención Sostenida 1, Figuras abstractas"
                               : "Atención Sostenida 2, Figuras abstractas";
                case TestType2Report.Letras:
                    return (this.TestClass == TestClass2Export.Simple)
                               ? "Atención Sostenida 1, Letras"
                               : "Atención Sostenida 2, Letras";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
