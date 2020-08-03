using System;

namespace Lab7_4JordanK
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile debra = new DatingProfile("Debra", "Zebra", 32, "Female");
            debra.WriteBio("Just a young lady looking for Mr. Right. Love long walks on the beach and movies (particularly a good romantic comedy). If that sounds like your thing, HMU! ;)");

            DatingProfile don = new DatingProfile("Don", "John", 36, "Male");
            don.WriteBio("hey");

            debra.SendMessage("Wow", "You sound so mysterious. Maybe u wanna get some coffee sometime? xD", don);
            don.ReadMessage();
        }
    }
}
