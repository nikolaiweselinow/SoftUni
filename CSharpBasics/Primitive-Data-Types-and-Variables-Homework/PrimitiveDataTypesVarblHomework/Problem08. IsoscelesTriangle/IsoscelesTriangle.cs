using System;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.



class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(@"   ©
  © ©
 ©   ©
© © © ©");


        //another way
        char star = '\u00a9';
        
        Console.WriteLine("{0}{1}", new string(' ', 3),new string(star,1));
        Console.WriteLine("{0}{1}{2}{1}", new string(' ', 2), new string(star, 1),new string(' ',1));
        Console.WriteLine("{0}{1}{2}{1}", new string(' ', 1), new string(star, 1), new string(' ', 3));
        Console.WriteLine("{0}{1}{0}{1}{0}{1}{0}", new string(star, 1), new string(' ', 1));

    }
}

