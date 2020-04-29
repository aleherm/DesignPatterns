using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Prototype
{
    [Serializable]
    class Car : ICarPrototype
    {
        public CarColor Color { get; set; }
        public ECarModel Model { private get;  set; }
        public EEngineType Engine { private get; set; }
        public bool IsClone { private get; set; }

        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        public Car Clone()
        {
            Car clonedCar = DeepCopy();
            clonedCar.IsClone = true;
            return clonedCar;
        }

        // method for cloning object 
        public Car DeepCopy()
        {
            return DeepClone<Car>(this);
        }

        public override string ToString()
        {
            return "______________New car built______________\nModel:" + Model + " | Color:" + Color + " | Engine:" + Engine;
        }
    }
}
