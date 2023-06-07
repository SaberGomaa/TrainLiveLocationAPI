using Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class TrainConfigration : IEntityTypeConfiguration<Train>
    {
        public void Configure(EntityTypeBuilder<Train> builder)
        {
            builder.HasData(
                // For each new Train Create new OBJ From Train

                new Train
                {
                    Id = 164,
                    // Complete the data like following examples
                    // Let Captial Letters as they are "Case Sensitive "
                    // روسي مكيف
                    Degree = "3rd Air Conditioned",
                    TrainNumber = "164",
                    NumOfSeat = 880,
                    NumOfTrainCars = 11,
                    Conductor = "",
                    Driver = "",
                    CurrentLocation = "",
                }
                // putting acomma ( , ) between each OBJ  
                ,
                new Train
                {
                    Id = 914,
                    // اولى وثانية مكيف
                    Degree = "1st & 2nd Air Conditioned",
                    TrainNumber = "914",
                    NumOfSeat = 572,
                    NumOfTrainCars = 10,
                    Conductor = "",
                    Driver = "",
                    CurrentLocation = "",
                }
                ,
                new Train
                {
                    Id = 18,
                    Degree = "3rd Air Conditioned",
                    TrainNumber = "18",
                    NumOfSeat = 880,
                    NumOfTrainCars = 11,
                    Conductor = "",
                    Driver = "",
                    CurrentLocation = "",
                }
                ,
                new Train
                {
                    Id = 916,
                    Degree = "VIP",
                    TrainNumber = "916",
                    NumOfSeat = 10,
                    NumOfTrainCars = 572,
                    Conductor = "",
                    Driver = "",
                    CurrentLocation = "",
                }
                ,
                new Train
                {
                    Id = 24,
                    //تهوية دينامكية او روسي
                    Degree = "Russian",
                    TrainNumber = "24",
                    NumOfSeat = 880,
                    NumOfTrainCars = 10,
                    Conductor = "",
                    Driver = "",
                    CurrentLocation = "",
                }

                );
        }

    }
}
