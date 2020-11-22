using System;
using System.Collections.Generic;
using System.Linq;

//Second iteration of Menu class
//Changed from two Lists to a List<KeyValuePair> in order to 
//ease initial Menu programming and keep things linked.

namespace ConsoleMath
{
    public class Menu
    {
        //From: https://stackoverflow.com/questions/8196117/c-sharp-get-and-set-properties-for-a-list-collection

        //To Create a Get:Set for a List type, this is the method.
        //Set is illegal?? So, we use a private readonly base List variable
        //  Then use an Add method (MenuOptionAdd(option)) in order to fill it.
        //   When we get, we create the public List type variable as an Interface
        //   and return the base one we filled.
        private readonly List<KeyValuePair<string, int>> _MenuOptionList = new List<KeyValuePair<string, int>>();

        public IList<KeyValuePair<string, int>> MenuOptionList { get { return _MenuOptionList; } }

        public void MenuOptionAdd(string option, int action)
        {
            _MenuOptionList.Add(new KeyValuePair<string, int>(option, action));
        }


        public int ShowMenu()
            {
                var myAction = new MenuAction();

                Console.Clear();

                //Search through all the items in _MenuOptionList
                //and display them.
                //
                //Add one to the Count of items in the List and print the 
                //Quit Menu option.

                //Menu Header is added as location 0
                //
                //So that the programmer can add things in their order choice, 
                //and use only one List, we use a List<KeyValuePair>
                //and we use a for loop to locate each item in order since 
                //the programmer may not have put them in order.

                for(int index = 0; index < MenuOptionList.Count; index++)
                {
                    KeyValuePair<string, int> result = MenuOptionList.SingleOrDefault(x => x.Value == index);
                    Console.WriteLine(result.Key);
                }
                
                Console.WriteLine((MenuOptionList.Count) + ") Exit");
                Console.Write("\r\nSelect an option: ");
 
                String Choice = Console.ReadLine();
                
                int retVal = Convert.ToInt32(Choice);
                if(retVal == MenuOptionList.Count)
                {
                    return 0;
                }
                else
                {
                    int response = myAction.runAction(retVal, MenuOptionList);
                    Console.ReadKey();
                    return response;
                }
            }

    }
}