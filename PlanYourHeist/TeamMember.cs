using System;
using System.Collections.Generic;
using System.Text;

namespace PlanYourHeist
{

    class TeamMember
    {
        public string Name { get; set; }

        int _skillLevel;
        public int SkillLevel 
        {
            get
            {
                return this._skillLevel;
            }

            set
            {
                this._skillLevel = Math.Abs(value);
            }
        }

        decimal _courageFactor;
        public decimal CourageFactor 
        {
            get
            {
                return this._courageFactor;
            }


            set 
            {
                this._courageFactor = Math.Round(value, 1);
            }

        }

        public TeamMember (string name)
        {
            Name = name;
        }
    }
}
