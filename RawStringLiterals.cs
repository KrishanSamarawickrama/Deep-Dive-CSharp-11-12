using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Dive_CSharp_11_12;
internal static class RawStringLiterals
{
    public static void Run()
    {
        Console.WriteLine("Raw String Literals (C# 12)");
        Console.WriteLine("");

        //Before
        string path = "C:\\Users\\Public\\Documents\\Report.txt";
        Console.WriteLine(path);

        //After
        string path12 = """C:\Users\Public\Documents\Report.txt""";
        Console.WriteLine(path12);

        // Before
        string htmlContent = "<html>\n\t<body>\n\t\t<h1>Welcome to my website!</h1>\n\t</body>\n</html>";
        Console.WriteLine(htmlContent);

        // After
        string htmlContent12 = @"""<html>
            <body>
                <h1>Welcome to my website!</h1>
            </body>
        </html>""";
        Console.WriteLine(htmlContent12);

        Console.WriteLine("");
    }
}
