///aisha mashrah
//10/19/22
//Restaurant Picker 
//the player is going to pick one of the categories(American,Indian ,Italian)and when the player picks one it will list Restaurant.
//peer review


Console.Clear();
Console.WriteLine("Lets PiCk A Categories ");
Console.WriteLine("American,Indian ,Italian,");


string userInput = Console.ReadLine().ToUpper();
System.Random ranNum= new System.Random();
switch (userInput){



    case "AMERICAN":
        {
             
    int num1 = ranNum.Next(1,11);
    Console.WriteLine("Player chooses " + userInput);
   
         switch (num1){
            case 1:
                Console.WriteLine("McDonald");
                break;
             case 2:
                    Console.WriteLine("Chick-fil-A");
                break;
            case 3:
                    Console.WriteLine("Taco Bell");
                break;
            case 4:
                    Console.WriteLine("Subway");
                break;
            case 5:
                    Console.WriteLine("Tasty Pot");
                break;
            case 6:
                    Console.WriteLine("Market Tavern");
                break;
            case 7:
                    Console.WriteLine("Island Gourmet Restaurant");
                break;
            case 8:
                    Console.WriteLine("burger king");
                break;
            case 9:
                    Console.WriteLine("CARL'S JR.");
                break;
            case 10:
                    Console.WriteLine("IN and Out burger");
                break;
                      
        }
        }
        break;
        
    case "INDIAN":
        
        int num2 = ranNum.Next(1, 11);
        Console.WriteLine("Player chooses " + userInput);
        
        switch (num2)
        {
            case 1:
                Console.WriteLine("Maharaja Indian Cuisine");
                break;
             case 2:
                    Console.WriteLine("India 4 U Restaurant and Bar");
                break;
            case 3:
                    Console.WriteLine("Tandoori Grill");
                break;
            case 4:
                    Console.WriteLine("The Amarvilas");
                break;
            case 5:
                    Console.WriteLine("Swagat Indian Cuisine");
                break;
            case 6:
                    Console.WriteLine("Royal India Cuisine & Bar");
                break;
            case 7:
                    Console.WriteLine("Curry on wheels");
                break;
            case 8:
                    Console.WriteLine("Shan-E-Punjab");
                break;
            case 9:
                    Console.WriteLine("Indian food bus");
                break;
            case 10:
                    Console.WriteLine("Indian Cafe");
                break;
                      
        }
          break;




    case "ITALIAN":
        
        int num3 = ranNum.Next(1, 11);
        Console.WriteLine("Player chooses " + userInput);
       
        switch (num3)
        {
            case 1:
                Console.WriteLine("Angelina's Spaghetti House");
                break;
             case 2:
                    Console.WriteLine("Express Pizza & GriLL");
                break;
            case 3:
                    Console.WriteLine("Mezzo");
                break;
            case 4:
                    Console.WriteLine("De Vega Brothers");
                break;
            case 5:
                    Console.WriteLine("Romano's Macaroni Grill");
                break;
            case 6:
                    Console.WriteLine("Olive Garden Italian Restaurant");
                break;
            case 7:
                    Console.WriteLine("Padella Italiana");
                break;
            case 8:
                    Console.WriteLine("De Vinci's Delicatessen & Catering");
                break;
            case 9:
                    Console.WriteLine("Giovannis Catering");
                break;
            case 10:
                    Console.WriteLine("De Vinci's Delicatessen");
                break;
                
                      
        }
        
    break;
     
        
     } 

    



    

        


        


    
            


