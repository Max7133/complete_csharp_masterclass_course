/////////////////////////////////////////////////////  INHERITANCE  /////////////////////////////////////////////////////

using csharp_inheritance_and_oop;

Post post1 = new Post("Tnx for gift!", true, "Max Pas");
Console.WriteLine(post1.ToString()); // 0 - Tnx for gift! - by Max Pas
ImagePost imagePost1 = new ImagePost("Check out my new shoes!", "Max Pas", "http://images.com/shoes", true);
Console.WriteLine(imagePost1.ToString()); // 2 - Check out my new shoes! - by Max Pas