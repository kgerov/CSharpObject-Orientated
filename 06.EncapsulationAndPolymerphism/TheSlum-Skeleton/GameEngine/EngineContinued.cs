using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Characters;

namespace TheSlum.GameEngine
{
    class EngineContinued : Engine
    {
        public EngineContinued()
            : base() { }

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    PrintCharactersStatus(characterList);
                    break;
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            if (inputParams[1] == "warrior")
	        {
                base.characterList.Add(new Warrior(inputParams[2].ToString(), Convert.ToInt32(inputParams[3]), Convert.ToInt32(inputParams[4]), inputParams[5] == "Red" ? Team.Red : Team.Blue));
	        } 
            else if (inputParams[1] == "mage")
	        {
                base.characterList.Add(new Mage(inputParams[2].ToString(), Convert.ToInt32(inputParams[3]), Convert.ToInt32(inputParams[4]), inputParams[5] == "Red" ? Team.Red : Team.Blue));
	        }
            else if (inputParams[1] == "healer")
	        {
                base.characterList.Add(new Healer(inputParams[2].ToString(), Convert.ToInt32(inputParams[3]), Convert.ToInt32(inputParams[4]), inputParams[5] == "Red" ? Team.Red : Team.Blue));
	        }
        }

        protected new void AddItem(string[] inputParams)
        {
            foreach (var character in characterList)
            {
                if (character.Id == inputParams[1])
                {
                    if (inputParams[2] == "axe")
                    {
                        character.AddToInventory(new Axe(inputParams[3]));
                    }
                    else if (inputParams[2] == "pill")
                    {
                        character.AddToInventory(new Pill(inputParams[3]));
                    }
                    else if (inputParams[2] == "injection")
                    {
                        character.AddToInventory(new Injection(inputParams[3]));
                    }
                    else if (inputParams[2] == "shield")
                    {
                        character.AddToInventory(new Shield(inputParams[3]));
                    }
                }
            }
        }
    }
}
