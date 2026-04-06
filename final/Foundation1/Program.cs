using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Rando Video #1", "Bob Joe", 128);
        Comment comment1 = new Comment("Not Bob Joe", "First");
        Comment comment2 = new Comment("Average Joe", "Cool video bro");
        Comment comment3 = new Comment("Above-Average Joe", "This is a lame video");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("How to Join Four Legs for Crochet Amigurumi", "Yarn-Woman", 380);
        Comment comment4 = new Comment("Grandma5000", "neat stitching");
        Comment comment5 = new Comment("Pencil Woman", "What's up hommie buddeh");
        Comment comment6 = new Comment("ReallyOldFogie", "Skadoodle harder");
        Comment comment10 = new Comment("Test Commenter", "Comment text lol");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment10);

        Video video3 = new Video("Why pink is the superior color", "Peggy Belle", 12000);
        Comment comment7 = new Comment("Pinky", "Pink is an alright color");
        Comment comment8 = new Comment("Blue Supremist", "No you're wrong, blue is the best color");
        Comment comment9 = new Comment("NeverEndingToaster", "Pink is a good color, but red is better");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        video1.DisplayDetails();
        video2.DisplayDetails();
        video3.DisplayDetails();
    }
}