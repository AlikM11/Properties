namespace Properties
{
    #region Repeat
    //Properties
    class Any
    {
        public int a;
        public Any(int a)//Constructor With parameters
        {
            this.a = a;
        }

    }
    #endregion

    #region Properties
    class Propertie
    {
        //private int a;

        //public void SetA(int a)
        //{
        //    this.a = a;
        //}
        //public int GetA() => a;

        //Full Property

        //private string _name;

        //public string Name
        //{
        //    get => _name;
        //    set => _name = value; 
        //}
        //Auto Propertie

        public string Surname { get; set; }

        //propg
        public int MachineName { get; private set; }

        public Propertie(int MachineName)
        {
           this.MachineName = MachineName;
        }

    }

    #endregion

    #region Static Classes

    static class Calculator
    {
        public static double Add(double num1, double num2) => num1 + num2;
        public static double Sub(double num1,double num2) => num1 - num2;
        public static double Mult(double num1,double num2) => num1 * num2;
        public static double Div(double num1, double num2) => num1 / num2;

        static Calculator()//static classlarin static constructoru olur
        {
            Console.WriteLine("Created!!!");
        }
    }

    #endregion

    #region Exception Handling
    #endregion
    class Program
    {

        static void Main()
        {
            #region Repeat
            //Any any = new(15);
            //Console.WriteLine(any.a);
            #endregion


            #region Properties
            //Propertie propertie = new(16);
            ////propertie.SetA(65);
            ////int result = propertie.GetA();
            ////Console.WriteLine(result);

            //Console.WriteLine(propertie.MachineName);
            #endregion


            #region Static Classes
            //static classlar ve ya propertiesler Static memory deyilen yerde saxlanilir

            //Calculator calculator = new Calculator();//static classlarin obyektini yaratmaq olmur

            //Static classlarin constructoru 1 defe yaranir ancaq hemmise istifade olunur

            //double result =  Calculator.Add(15,30);
            //double result1 = Calculator.Mult(15,30);
            //double result2 = Calculator.Div(15,30);
            //double result3 = Calculator.Sub(15,30);

            //Console.WriteLine($"Add: {result}");
            //Console.WriteLine($"Mult: {result1}");
            //Console.WriteLine($"Div: {result2}");
            //Console.WriteLine($"Sub: {result3}");



            #endregion

            #region Exception Handling
            //int[] arr = new int[] { 1, 2, 3 };

            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n > arr.Length - 1) { Console.WriteLine("Olmaz"); }
            //else Console.WriteLine(arr[n]);
            int[] arr = { 1, 2, 3, 4 };

            try
            {
                Console.WriteLine(arr[418541]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //int a = 'a';
            //Console.WriteLine((char)a);


            #endregion
        }
    }
}