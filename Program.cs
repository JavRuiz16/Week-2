using System;
// class Homework2 {
//   static void Main() {

//     Console.WriteLine("Please input a letter grade:");
//     //get grade from the user
//     char grade=Console.ReadLine()[0];
//     //switch block
//     switch(grade) {
//         //check if grade is A
//         //if A then print 4
//         case 'A': Console.WriteLine("GPA point: 4");
//                   break;
//         case 'B': Console.WriteLine("GPA point: 3");
//                   break;
//         //check if grade C then print 2
//         case 'C': Console.WriteLine("GPA point: 2");
//                   break;
//         case 'D': Console. WriteLine("GPA point: 1");
//                   break;
//         case 'F': Console.WriteLine("GPA point: 0"); 
//                   break; 
//         //if any letter other then a,b,c,d,f
//         default:  Console.WriteLine("Wrong Letter Grade!");
//                   break;
//     }
//   }
// }





class Homework2part2 {
  static void Main() {
     
    Console.WriteLine("Please input the first num:");
    int a=Convert.ToInt16(Console.ReadLine()); 
    Console.WriteLine("Please input the second num:");
    int b=Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Please input the third num:");
    int c=Convert.ToInt16(Console.ReadLine());
    //This declares a variable smallest
    int smallest=0;
    //this will check if a is the smallest value
    if(a<b) {
        if(a<c) {
            smallest=a;
        }
    }
    //this will check if b is the smallest value
    if(b<a) {
        if(b<c) {
            smallest=b;
        }
    }
    //this will check if c is the smallest value
    if(c<a) {
        if(c<b) {
            smallest=c;
        }
    }
    //This will print the smallest value
    Console.WriteLine("The smallest value is: {0}",smallest);
  }
}
