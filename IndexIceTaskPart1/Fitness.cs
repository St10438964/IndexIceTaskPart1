using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexIceTaskPart1
{
    public class Fitness
    {
        int fitPackage, fitPrice;
        string gymChain, gymBrand, gymLocation ;

        public Fitness(int fitPackage, int fitPrice, string gymChain, string gymBrand, string gymLocation)
        {
            this.fitPackage = fitPackage;
            this.fitPrice = fitPrice;
            this.gymChain = gymChain;
            this.gymBrand = gymBrand;
            this.gymLocation = gymLocation;
        }

        //first index, allows access using integers
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.fitPackage; // return value based on index
                else if (index == 1)
                    return this.fitPrice;
                else if (index == 2)
                    return this.gymChain;
                else if (index == 3)
                    return this.gymBrand;
                else if (index == 4)
                    return this.gymLocation;
                return null;
            }
            set
            {
                if (index == 0)
                    this.fitPackage = (int)value; // sets value based on index
                else if (index == 1)
                    this.fitPrice = (int)value;
                else if (index == 2)
                    this.gymChain = (string)value;
                else if (index == 3)
                    this.gymBrand = (string)value;
                else if (index == 4)
                    this.gymLocation = (string)value;
            }
        }

        //Second indexer, using string index, attribute names
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("fitpackage"))
                    return this.fitPackage;
                else if (attrName.ToLower().Equals("fitprice"))
                    return this.fitPrice;
                else if (attrName.ToLower().Equals("gymchain"))
                    return this.gymChain;
                else if (attrName.ToLower().Equals("gymbrand"))
                    return this.gymBrand;
                else if (attrName.ToLower().Equals("gymlocation"))
                    return this.gymLocation;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("fitpackage"))
                    this.fitPackage = (int)value;
                else if (attrName.ToLower().Equals("fitprice"))
                    this.fitPrice = (int)value;
                else if (attrName.ToLower().Equals("gymchain"))
                    this.gymChain = (string)value;
                else if (attrName.ToLower().Equals("gymbrand"))
                    this.gymBrand = (string)value;
                else if (attrName.ToLower().Equals("gymlocation"))
                    this.gymLocation = (string)value;
            }
        }
    }
}
