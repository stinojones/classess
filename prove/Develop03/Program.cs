class Program
{
    static void Main(string[] args)
    {
        Scripture firstScripture = new Scripture(new Reference("Moroni", 10, 3, 5), "3 Behold, I would exhort you that when ye shall read these things, \nif it be wisdom in God that ye should read them, that ye would remember how amerciful the Lord hath been unto the children of men, \nfrom the creation of Adam even down until the time that ye shall receive these things, and ponder it in your chearts. \n4 And when ye shall receive these things, I would exhort you that ye would aask God, the Eternal Father, in the name of Christ, if these things are not true;\n and if ye shall ask with a sincere heart,\n with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. \n5 And by the power of the Holy Ghost ye may know the truth of all things.");

        firstScripture.ConvertStringToList();
        firstScripture.HideWords();
    }
}