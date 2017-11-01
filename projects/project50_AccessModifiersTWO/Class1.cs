using System;
using project50_AccessModifiersONE;

namespace project50_AccessModifiersTWO
{

    internal class Class1:Program// The class has to be public to access its object C1
    {
        public static void Main()
        {
            Program P = new Program();
            P.printOnePublic();
            //See here only public method can be accessed not private and protected
            Class1 C1 = new Class1();
            C1.printFiveProtectedInternal();
            // Here we can only access this protected Internal method using the object of current class object 
            //but not with the class object where the method is implemented
        }
    }
}
