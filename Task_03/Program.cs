using System;
using System.Collections.Generic;

namespace TaskThree
{

    /// Задача - перепишите данный код так, чтобы он работал через коллекции C#, вместо конструкции switch


    public enum ActionType
    {
        Create,

        Read,

        Update,

        Delete
        
    }

    class Program
    {
        static void Main(string[] args)
        {

            var actions = new List<ActionType>
            {
                ActionType.Create,
                ActionType.Read,
                ActionType.Update,
                ActionType.Delete,
            };


            var type = ActionType.Delete; 

            foreach (ActionType types in actions)
            {
                if (type.Equals(ActionType.Read))
                {
                    type = ActionType.Read;
                    ReadMethod(type);
                    break;
                }
                else if (type.Equals(ActionType.Delete))
                {
                    type = ActionType.Delete;
                    DeleteMethod(type);
                    break;
                }
                else if (type.Equals(ActionType.Update))
                {
                    type = ActionType.Update;
                    UpdateMethod(type);
                    break;

                }
                else if (type.Equals(ActionType.Create))
                {
                    type = ActionType.Create;
                    CreateMethod(type);
                    break;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static void CreateMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }

        private static void ReadMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }

        private static void UpdateMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }

        private static void DeleteMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }
    }
}