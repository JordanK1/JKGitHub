using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        //2A
        string pattern = @"[d-e]";
        string input = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }


        //2B
        string patternb = @"[d-e][*d]";
        string inputb = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions optionsb = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(inputb, patternb, optionsb))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }


        //2C
        string patternc = @"[a][a-z][a]";
        string inputc = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions optionsc = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(inputc, patternc, optionsc))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }


        //2D
        string patternd = @"[ ][p][a-z]*";
        string inputd = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions optionsd = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(inputd, patternd, optionsd))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }


        //2E
        string patterne = @"[a-z]*[e][ ]";
        string inpute = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions optionse = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(inpute, patterne, optionse))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }


        //2F
        string patternf = @"[A-Z]";
        string inputf = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions optionsf = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(inputf, patternf, optionsf))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}


