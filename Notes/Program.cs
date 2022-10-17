namespace Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var note = XmlHelper.LoadNote();

            Console.WriteLine($"Note text: {note.Body}");

            var newNote = new Note
            {
                To = "Mom",
                From = "Me",
                Heading = "Greetings from Home",
                Body = "Me and sis miss you a lot, hope you are well!",
            };

            XmlHelper.SaveNote(newNote);
            var loadedNewNote = XmlHelper.LoadNote();

            Console.WriteLine($"New note text: {loadedNewNote.Body}");
        }
    }
}