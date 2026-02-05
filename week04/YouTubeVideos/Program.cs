using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to program in C#", "João Silva", 600);
        video1.AddComment(new Comment("Maria", "Great video!"));
        video1.AddComment(new Comment("Pedro", "Very useful"));
        video1.AddComment(new Comment("Ana", "Learned so much!"));
        videos.Add(video1);

        Video video2 = new Video("Introduction to OOP", "Carlos Santos", 450);
        video2.AddComment(new Comment("Lucas", "Amazing teacher!"));
        video2.AddComment(new Comment("Fernanda", "Post part 2 please!"));
        video2.AddComment(new Comment("Roberto", "Great explanation"));
        video2.AddComment(new Comment("Julia", "Helped a lot!"));
        videos.Add(video2);

        Video video3 = new Video("Lists in C#", "Beatriz Lima", 720);
        video3.AddComment(new Comment("Paulo", "Can you do more C# videos?"));
        video3.AddComment(new Comment("Mariana", "I was having such a diffulct with this!"));
        video3.AddComment(new Comment("Diego", "Just saved my program!"));
        videos.Add(video3);

        Video video4 = new Video("OOP with C#", "Ricardo Oliveira", 900);
        video4.AddComment(new Comment("Camila", "One of the better explanations!"));
        video4.AddComment(new Comment("Bruno", "Well explained, thank you!"));
        video4.AddComment(new Comment("Larissa", "I need to recomend this to my friends"));
        video4.AddComment(new Comment("Thiago", "I finally could undestand!"));
        videos.Add(video4);
        
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}