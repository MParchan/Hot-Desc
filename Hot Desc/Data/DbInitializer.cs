using Hot_Desc.Models;

namespace Hot_Desc.Data
{
    public class DbInitializer
    {
        public static void Initialize(HotDescDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Workplaces.Any())
            {
                return;
            }

            var workplaces = new Workplace[]
            {
                new Workplace{Floor=1,Room=1,Table=1},
                new Workplace{Floor=1,Room=1,Table=2},
                new Workplace{Floor=1,Room=2,Table=1},
                new Workplace{Floor=1,Room=2,Table=2},
                new Workplace{Floor=1,Room=2,Table=3},
                new Workplace{Floor=2,Room=1,Table=1},
                new Workplace{Floor=2,Room=1,Table=2},
                new Workplace{Floor=2,Room=1,Table=3},
                new Workplace{Floor=2,Room=2,Table=1},
                new Workplace{Floor=2,Room=2,Table=2}
            };
            foreach (Workplace w in workplaces)
            {
                context.Workplaces.Add(w);
            }

            var equipments = new Equipment[]
            {
                new Equipment{Type="Monitor"},
                new Equipment{Type="Keyboard"},
                new Equipment{Type="Mouse"},
                new Equipment{Type="PC"},
                new Equipment{Type="Microphone"},
                new Equipment{Type="Camera"}
            };
            foreach (Equipment e in equipments)
            {
                context.Equipments.Add(e);
            }
            context.SaveChanges();

            var equipmentForWorkplace = new EquipmentForWorkplace[]
            {
                new EquipmentForWorkplace{WorkplaceId=1,EquipmentId=1,Count=1},
                new EquipmentForWorkplace{WorkplaceId=1,EquipmentId=2,Count=1},
                new EquipmentForWorkplace{WorkplaceId=1,EquipmentId=3,Count=1},
                new EquipmentForWorkplace{WorkplaceId=1,EquipmentId=4,Count=1},
                new EquipmentForWorkplace{WorkplaceId=1,EquipmentId=5,Count=1},
                new EquipmentForWorkplace{WorkplaceId=1,EquipmentId=6,Count=1},
                new EquipmentForWorkplace{WorkplaceId=2,EquipmentId=1,Count=3},
                new EquipmentForWorkplace{WorkplaceId=2,EquipmentId=2,Count=2},
                new EquipmentForWorkplace{WorkplaceId=2,EquipmentId=3,Count=2},
                new EquipmentForWorkplace{WorkplaceId=2,EquipmentId=4,Count=2},
                new EquipmentForWorkplace{WorkplaceId=2,EquipmentId=5,Count=1},
                new EquipmentForWorkplace{WorkplaceId=2,EquipmentId=6,Count=1},
                new EquipmentForWorkplace{WorkplaceId=3,EquipmentId=1,Count=1},
                new EquipmentForWorkplace{WorkplaceId=3,EquipmentId=2,Count=1},
                new EquipmentForWorkplace{WorkplaceId=3,EquipmentId=3,Count=1},
                new EquipmentForWorkplace{WorkplaceId=3,EquipmentId=4,Count=1},
                new EquipmentForWorkplace{WorkplaceId=3,EquipmentId=5,Count=1},
                new EquipmentForWorkplace{WorkplaceId=3,EquipmentId=6,Count=2},
                new EquipmentForWorkplace{WorkplaceId=4,EquipmentId=1,Count=1},
                new EquipmentForWorkplace{WorkplaceId=4,EquipmentId=2,Count=1},
                new EquipmentForWorkplace{WorkplaceId=4,EquipmentId=3,Count=1},
                new EquipmentForWorkplace{WorkplaceId=4,EquipmentId=4,Count=3},
                new EquipmentForWorkplace{WorkplaceId=4,EquipmentId=5,Count=1},
                new EquipmentForWorkplace{WorkplaceId=4,EquipmentId=6,Count=1},
                new EquipmentForWorkplace{WorkplaceId=5,EquipmentId=1,Count=1},
                new EquipmentForWorkplace{WorkplaceId=5,EquipmentId=2,Count=2},
                new EquipmentForWorkplace{WorkplaceId=5,EquipmentId=3,Count=1},
                new EquipmentForWorkplace{WorkplaceId=5,EquipmentId=4,Count=1},
                new EquipmentForWorkplace{WorkplaceId=5,EquipmentId=5,Count=1},
                new EquipmentForWorkplace{WorkplaceId=5,EquipmentId=6,Count=1},
                new EquipmentForWorkplace{WorkplaceId=6,EquipmentId=1,Count=1},
                new EquipmentForWorkplace{WorkplaceId=6,EquipmentId=2,Count=1},
                new EquipmentForWorkplace{WorkplaceId=6,EquipmentId=3,Count=1},
                new EquipmentForWorkplace{WorkplaceId=6,EquipmentId=4,Count=1},
                new EquipmentForWorkplace{WorkplaceId=6,EquipmentId=5,Count=1},
                new EquipmentForWorkplace{WorkplaceId=6,EquipmentId=6,Count=1},
                new EquipmentForWorkplace{WorkplaceId=7,EquipmentId=1,Count=1},
                new EquipmentForWorkplace{WorkplaceId=7,EquipmentId=2,Count=1},
                new EquipmentForWorkplace{WorkplaceId=7,EquipmentId=3,Count=3},
                new EquipmentForWorkplace{WorkplaceId=7,EquipmentId=4,Count=1},
                new EquipmentForWorkplace{WorkplaceId=7,EquipmentId=5,Count=1},
                new EquipmentForWorkplace{WorkplaceId=7,EquipmentId=6,Count=1},
                new EquipmentForWorkplace{WorkplaceId=8,EquipmentId=1,Count=3},
                new EquipmentForWorkplace{WorkplaceId=8,EquipmentId=2,Count=2},
                new EquipmentForWorkplace{WorkplaceId=8,EquipmentId=3,Count=1},
                new EquipmentForWorkplace{WorkplaceId=8,EquipmentId=4,Count=2},
                new EquipmentForWorkplace{WorkplaceId=8,EquipmentId=5,Count=1},
                new EquipmentForWorkplace{WorkplaceId=9,EquipmentId=6,Count=1},
                new EquipmentForWorkplace{WorkplaceId=9,EquipmentId=1,Count=1},
                new EquipmentForWorkplace{WorkplaceId=9,EquipmentId=2,Count=1},
                new EquipmentForWorkplace{WorkplaceId=9,EquipmentId=3,Count=1},
                new EquipmentForWorkplace{WorkplaceId=9,EquipmentId=4,Count=1},
                new EquipmentForWorkplace{WorkplaceId=9,EquipmentId=5,Count=1},
                new EquipmentForWorkplace{WorkplaceId=9,EquipmentId=6,Count=1},
                new EquipmentForWorkplace{WorkplaceId=10,EquipmentId=1,Count=2},
                new EquipmentForWorkplace{WorkplaceId=10,EquipmentId=2,Count=1},
                new EquipmentForWorkplace{WorkplaceId=10,EquipmentId=3,Count=1},
                new EquipmentForWorkplace{WorkplaceId=10,EquipmentId=4,Count=1},
                new EquipmentForWorkplace{WorkplaceId=10,EquipmentId=5,Count=1},
                new EquipmentForWorkplace{WorkplaceId=10,EquipmentId=6,Count=1}
            };
            foreach (EquipmentForWorkplace e in equipmentForWorkplace)
            {
                context.EquipmentsForWorkplaces.Add(e);
            }
            context.SaveChanges();

        }
    }
}
