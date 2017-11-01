using System;
/// <summary>
/// This assembly has a type and type members
/// we are going to practice some code using access modifiers
/// </summary>
namespace project50_AccessModifiersONE
{
    /// <summary>
    /// This is a type which allows only public and internal.
    ///  The default access modifier for a type is internal
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This is a type member which has default access modifier of Private
        /// </summary>
        public void printOnePublic()
        {
            Console.WriteLine("This is a print method PUBLIC in project50_AccessModifiers class program ");

        }
        private void printTwoPrivate()
        {
            Console.WriteLine("This is a print method PRIVATE in project50_AccessModifiers class program ");

        }
        protected void printThreeProtected()
        {
            Console.WriteLine("This is a print method PROTECTED in project50_AccessModifiers class program ");

        }
        internal void printFourInternal()
        {
            Console.WriteLine("This is a print method INTERNAL in project50_AccessModifiers class program ");

        }
        protected internal void printFiveProtectedInternal()
        {
            Console.WriteLine("This is a print method PROTECTED INTERNAL in project50_AccessModifiers class program ");

        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.printOnePublic();
            pr.printTwoPrivate();
            pr.printThreeProtected();
            pr.printFourInternal();
            pr.printFiveProtectedInternal();
        }
    }
}