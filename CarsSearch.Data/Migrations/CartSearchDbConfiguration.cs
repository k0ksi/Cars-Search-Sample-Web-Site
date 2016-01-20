namespace CarsSearch.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class CartSearchDbConfiguration : DbMigrationsConfiguration<CarsSearchDbContext>
    {
        public CartSearchDbConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "CarsSearch.Data.CarsSearchDbContext";
        }

        protected override void Seed(CarsSearchDbContext context)
        {
            if (!context.Cars.Any())
            {
                var brands = this.LoadBrands(context);
                var importers = this.LoadImporters(context);

                var audiId = brands
                    .FirstOrDefault(x => x.Name == "Audi").Id;
                var bmwId = brands
                    .FirstOrDefault(x => x.Name == "BMW").Id;
                var daciaId = brands
                    .FirstOrDefault(x => x.Name == "Dacia").Id;
                var fiatId = brands
                    .FirstOrDefault(x => x.Name == "Fiat").Id;
                var vwId = brands
                    .FirstOrDefault(x => x.Name == "Volkswagen").Id;
                var mercedesId = brands
                    .FirstOrDefault(x => x.Name == "Mercedes").Id;
                var renaultId = brands
                    .FirstOrDefault(x => x.Name == "Renault").Id;
                var peugeotId = brands
                    .FirstOrDefault(x => x.Name == "Peugeot").Id;
                var volvoId = brands
                    .FirstOrDefault(x => x.Name == "Volvo").Id;
                var dodgeId = brands
                    .FirstOrDefault(x => x.Name == "Dodge").Id;
                var fordId = brands
                    .FirstOrDefault(x => x.Name == "Ford").Id;
                var toyotaId = brands
                    .FirstOrDefault(x => x.Name == "Toyota").Id;
                var hondaId = brands
                    .FirstOrDefault(x => x.Name == "Honda").Id;
                var mazdaId = brands
                    .FirstOrDefault(x => x.Name == "Mazda").Id;

                var happyCarsId = importers
                    .FirstOrDefault(x => x.Name == "Happy Cars").Id;
                var niceAndCheapId = importers
                    .FirstOrDefault(x => x.Name == "Nice & Cheap").Id;
                var bellaItaliaId = importers
                    .FirstOrDefault(x => x.Name == "Bella Italia").Id;
                var germanAutomationId = importers
                    .FirstOrDefault(x => x.Name == "German Automotion").Id;
                var frenchConnectionId = importers
                    .FirstOrDefault(x => x.Name == "The French Connection").Id;
                var asianVehiclesId = importers
                    .FirstOrDefault(x => x.Name == "Asia's Finest").Id;
                var americanDaydreamsId = importers
                    .FirstOrDefault(x => x.Name == "American Daydreams").Id;

                var cars = new List<Car>()
                {
                    new Car()
                    {
                        BrandId = audiId,
                        Description = "The Audi 80 is a compact executive car produced by the German manufacturer Audi.",
                        HorsePower = 64.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1978
                    },
                    new Car()
                    {
                        BrandId = audiId,
                        Description = "The Audi Quattro is a road and rally car.",
                        HorsePower = 112.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1980
                    },
                    new Car()
                    {
                        BrandId = audiId,
                        Description = "The Audi A8 is a four-door, full-size, luxury sedan car.",
                        HorsePower = 330.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1994
                    },
                    new Car()
                    {
                        BrandId = audiId,
                        Description = "The Audi A4 is a line of compact executive cars.",
                        HorsePower = 185.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1994
                    },
                    new Car()
                    {
                        BrandId = audiId,
                        Description = "The Audi A3 is a Small Family/Compact car.",
                        HorsePower = 148.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1996
                    },
                    new Car()
                    {
                        BrandId = bmwId,
                        Description = "The BMW 3 Series Compact is a compact executive car.",
                        HorsePower = 154.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1993
                    },
                    new Car()
                    {
                        BrandId = bmwId,
                        Description = "The BMW M3 is a high-performance version of the BMW 3-Series.",
                        HorsePower = 320.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 2001
                    },
                    new Car()
                    {
                        BrandId = bmwId,
                        Description = "The BMW 1 Series is a series of compact luxury cars.",
                        HorsePower = 160.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 2005
                    },
                    new Car()
                    {
                        BrandId = bmwId,
                        Description = "The BMW New Class coupé range has a coupé body style built by Karmann for BMW.",
                        HorsePower = 98.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1965
                    },
                    new Car()
                    {
                        BrandId = bmwId,
                        Description = "The BMW 320 was a saloon car.",
                        HorsePower = 50.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1938
                    },
                    new Car()
                    {
                        BrandId = daciaId,
                        Description = "The Dacia Dokker is a leisure activity vehicle.",
                        HorsePower = 110.0,
                        ImporterId = niceAndCheapId,
                        YearManufactured = 2012
                    },
                    new Car()
                    {
                        BrandId = daciaId,
                        Description = "The Dacia Duster is a compact SUV.",
                        HorsePower = 123.0,
                        ImporterId = niceAndCheapId,
                        YearManufactured = 2010
                    },
                    new Car()
                    {
                        BrandId = daciaId,
                        Description = "The Dacia Lodgy is a compact multi-purpose vehicle.",
                        HorsePower = 85.0,
                        ImporterId = niceAndCheapId,
                        YearManufactured = 2012
                    },
                    new Car()
                    {
                        BrandId = daciaId,
                        Description = "The Dacia Logan is a small family car or compact MPV.",
                        HorsePower = 105.0,
                        ImporterId = niceAndCheapId,
                        YearManufactured = 2004
                    },
                    new Car()
                    {
                        BrandId = daciaId,
                        Description = "Dacia Sandero is a Subcompact car.",
                        HorsePower = 77.0,
                        ImporterId = niceAndCheapId,
                        YearManufactured = 2007
                    },
                    new Car()
                    {
                        BrandId = fiatId,
                        Description = "The Fiat Panda is a city car.",
                        HorsePower = 48.0,
                        ImporterId = bellaItaliaId,
                        YearManufactured = 1982
                    },
                    new Car()
                    {
                        BrandId = fiatId,
                        Description = "The Fiat Punto is a supermini car.",
                        HorsePower = 75.0,
                        ImporterId = bellaItaliaId,
                        YearManufactured = 2005
                    },
                    new Car()
                    {
                        BrandId = fiatId,
                        Description = "The Fiat Bravo is a small family car.",
                        HorsePower = 79.0,
                        ImporterId = bellaItaliaId,
                        YearManufactured = 2000
                    },
                    new Car()
                    {
                        BrandId = fiatId,
                        Description = "The Fiat Brava is a small family car.",
                        HorsePower = 102.0,
                        ImporterId = bellaItaliaId,
                        YearManufactured = 1997
                    },
                    new Car()
                    {
                        BrandId = fiatId,
                        Description = "The Fiat Punto is a supermini car.",
                        HorsePower = 75.0,
                        ImporterId = bellaItaliaId,
                        YearManufactured = 2008
                    },
                    new Car()
                    {
                        BrandId = vwId,
                        Description = "The Volkswagen Golf Mk3 is a small family car.",
                        HorsePower = 89.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1996
                    },
                    new Car()
                    {
                        BrandId = vwId,
                        Description = "The Volkswagen Passat is a large family car.",
                        HorsePower = 112.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1996
                    },
                    new Car()
                    {
                        BrandId = vwId,
                        Description = "The Volkswagen Polo Mk3 is a supermini car.",
                        HorsePower = 62.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 1997
                    },
                    new Car()
                    {
                        BrandId = vwId,
                        Description = "The Volkswagen Scirocco is a sport compact coupe.",
                        HorsePower = 132.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 2009
                    },
                    new Car()
                    {
                        BrandId = vwId,
                        Description = "The Volkswagen Phaeton is a full-size luxury sedan/saloon.",
                        HorsePower = 272.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 2009
                    },
                    new Car()
                    {
                        BrandId = mercedesId,
                        Description = "The Mercedes-Benz SLS AMG is a front-engine, 2-seater luxury car.",
                        HorsePower = 456.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 2014
                    },
                    new Car()
                    {
                        BrandId = mercedesId,
                        Description = "The Mercedes-Benz SLR McLaren is a grand tourer car.",
                        HorsePower = 557.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 2010
                    },
                    new Car()
                    {
                        BrandId = mercedesId,
                        Description = "The Mercedes-Benz CLK500 is a mid-size luxury coupé.",
                        HorsePower = 215.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 2009
                    },
                    new Car()
                    {
                        BrandId = mercedesId,
                        Description = "The Mercedes-Benz W164 is a SUV vehicle.",
                        HorsePower = 192.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 2009
                    },
                    new Car()
                    {
                        BrandId = mercedesId,
                        Description = "The Mercedes-Benz SL500 is a mid-size luxury coupé.",
                        HorsePower = 292.0,
                        ImporterId = germanAutomationId,
                        YearManufactured = 2008
                    },
                    new Car()
                    {
                        BrandId = renaultId,
                        Description = "The Renault Kangoo and the Kangoo Express are a range of leisure activity vehicles.",
                        HorsePower = 110.0,
                        ImporterId = frenchConnectionId,
                        YearManufactured = 2011
                    },
                    new Car()
                    {
                        BrandId = renaultId,
                        Description = "The Renault Magnum is a heavy-duty truck.",
                        HorsePower = 440.0,
                        ImporterId = frenchConnectionId,
                        YearManufactured = 2012
                    },
                    new Car()
                    {
                        BrandId = renaultId,
                        Description = "The Renault Master is an upper-medium size van.",
                        HorsePower = 160.0,
                        ImporterId = frenchConnectionId,
                        YearManufactured = 1999
                    },
                    new Car()
                    {
                        BrandId = renaultId,
                        Description = "The Renault Master is an upper-medium size van.",
                        HorsePower = 120.0,
                        ImporterId = frenchConnectionId,
                        YearManufactured = 1992
                    },
                    new Car()
                    {
                        BrandId = renaultId,
                        Description = "The Renault Trafic is a light commercial vehicle.",
                        HorsePower = 89.0,
                        ImporterId = frenchConnectionId,
                        YearManufactured = 1988
                    },
                    new Car()
                    {
                        BrandId = peugeotId,
                        Description = "The Peugeot 307 is a small family car.",
                        HorsePower = 91.0,
                        ImporterId = frenchConnectionId,
                        YearManufactured = 2001
                    },
                    new Car()
                    {
                        BrandId = peugeotId,
                        Description = "The Peugeot 403 is a sedan car.",
                        HorsePower = 48.0,
                        ImporterId = frenchConnectionId,
                        YearManufactured = 1965
                    },
                    new Car()
                    {
                        BrandId = peugeotId,
                        Description = "The Peugeot 604 is an executive car.",
                        HorsePower = 68.0,
                        ImporterId = frenchConnectionId,
                        YearManufactured = 1984
                    },
                    new Car()
                    {
                        BrandId = peugeotId,
                        Description = "The Peugeot 309 is a small family car.",
                        HorsePower = 78.0,
                        ImporterId = frenchConnectionId,
                        YearManufactured = 1991
                    },
                    new Car()
                    {
                        BrandId = peugeotId,
                        Description = "The Peugeot 407 is a large family car.",
                        HorsePower = 111.0,
                        ImporterId = frenchConnectionId,
                        YearManufactured = 2005
                    },
                    new Car()
                    {
                        BrandId = volvoId,
                        Description = "The Volvo S40 is a small family car.",
                        HorsePower = 104.0,
                        ImporterId = happyCarsId,
                        YearManufactured = 2005
                    },
                    new Car()
                    {
                        BrandId = volvoId,
                        Description = "The Volvo S70 was a compact executive car.",
                        HorsePower = 124.0,
                        ImporterId = happyCarsId,
                        YearManufactured = 1999
                    },
                    new Car()
                    {
                        BrandId = volvoId,
                        Description = "The Volvo S80 is an executive car.",
                        HorsePower = 138.0,
                        ImporterId = happyCarsId,
                        YearManufactured = 2003
                    },
                    new Car()
                    {
                        BrandId = volvoId,
                        Description = "The Volvo S40 is a small family car.",
                        HorsePower = 104.0,
                        ImporterId = happyCarsId,
                        YearManufactured = 2005
                    },
                    new Car()
                    {
                        BrandId = volvoId,
                        Description = "The Volvo C30 is a compact four-seater.",
                        HorsePower = 250.0,
                        ImporterId = happyCarsId,
                        YearManufactured = 2013
                    },
                    new Car()
                    {
                        BrandId = dodgeId,
                        Description = "The Dodge Avenger is a front-wheel drive, mid-size sedan.",
                        HorsePower = 140.0,
                        ImporterId = americanDaydreamsId,
                        YearManufactured = 1998
                    },
                    new Car()
                    {
                        BrandId = dodgeId,
                        Description = "The Dodge Challenger is a performance sport's car.",
                        HorsePower = 290.0,
                        ImporterId = americanDaydreamsId,
                        YearManufactured = 2009
                    },
                    new Car()
                    {
                        BrandId = dodgeId,
                        Description = "The Dodge Charger SRT 392 is a performance sport's car.",
                        HorsePower = 330.0,
                        ImporterId = americanDaydreamsId,
                        YearManufactured = 2015
                    },
                    new Car()
                    {
                        BrandId = dodgeId,
                        Description = "The Dodge Viper SRT is a sports car.",
                        HorsePower = 400.0,
                        ImporterId = americanDaydreamsId,
                        YearManufactured = 1994
                    },
                    new Car()
                    {
                        BrandId = dodgeId,
                        Description = "The Dodge Venom is a rear wheel drive concept car.",
                        HorsePower = 260.0,
                        ImporterId = americanDaydreamsId,
                        YearManufactured = 1995
                    },
                    new Car()
                    {
                        BrandId = fordId,
                        Description = "The Ford Focus is a compact car.",
                        HorsePower = 225.0,
                        ImporterId = americanDaydreamsId,
                        YearManufactured = 1999
                    },
                    new Car()
                    {
                        BrandId = fordId,
                        Description = "The Ford Fiesta is a supermini car .",
                        HorsePower = 96.0,
                        ImporterId = americanDaydreamsId,
                        YearManufactured = 1998
                    },
                    new Car()
                    {
                        BrandId = fordId,
                        Description = "The Ford Mondeo is a mid-size or large family car.",
                        HorsePower = 110.0,
                        ImporterId = americanDaydreamsId,
                        YearManufactured = 1994
                    },
                    new Car()
                    {
                        BrandId = fordId,
                        Description = "The Ford GT is an American mid-engine two-seater super car.",
                        HorsePower = 550.0,
                        ImporterId = americanDaydreamsId,
                        YearManufactured = 2006
                    },
                    new Car()
                    {
                        BrandId = fordId,
                        Description = "The Ford Mustang is an American automobile.",
                        HorsePower = 225.0,
                        ImporterId = americanDaydreamsId,
                        YearManufactured = 1999
                    },
                    new Car()
                    {
                        BrandId = toyotaId,
                        Description = "The Toyota Aygo is a city car.",
                        HorsePower = 54.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2006
                    },
                    new Car()
                    {
                        BrandId = toyotaId,
                        Description = "The Toyota Auris is a compact hatchback.",
                        HorsePower = 276.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2008
                    },
                    new Car()
                    {
                        BrandId = toyotaId,
                        Description = "The Toyota Auris is a compact hatchback.",
                        HorsePower = 276.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2008
                    },
                    new Car()
                    {
                        BrandId = toyotaId,
                        Description = "The Toyota Yaris is a subcompact car.",
                        HorsePower = 110.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2000
                    },
                    new Car()
                    {
                        BrandId = toyotaId,
                        Description = "The Toyota Allion is a sedan car.",
                        HorsePower = 112.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2003
                    },
                    new Car()
                    {
                        BrandId = hondaId,
                        Description = "The Honda Accord is a series of automobiles.",
                        HorsePower = 68.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 1976
                    },
                    new Car()
                    {
                        BrandId = hondaId,
                        Description = "The Honda Civic is a line of compact cars.",
                        HorsePower = 118.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 1999
                    },
                    new Car()
                    {
                        BrandId = hondaId,
                        Description = "The Honda Vamos is a Mini SUV leisure vehicle.",
                        HorsePower = 58.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 1973
                    },
                    new Car()
                    {
                        BrandId = hondaId,
                        Description = "The Honda Stream is a compact MPV.",
                        HorsePower = 148.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2013
                    },
                    new Car()
                    {
                        BrandId = hondaId,
                        Description = "The Honda FCX Clarity is a hydrogen fuel cell automobile.",
                        HorsePower = 130.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2014
                    },
                    new Car()
                    {
                        BrandId = mazdaId,
                        Description = "The Mazda CX-7 is a mid-size crossover SUV.",
                        HorsePower = 130.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2007
                    },
                    new Car()
                    {
                        BrandId = mazdaId,
                        Description = "The Mazda MX-5 is a lightweight two-seater.",
                        HorsePower = 220.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2010
                    },
                    new Car()
                    {
                        BrandId = mazdaId,
                        Description = "The Mazda Persona is four-door hardtop sedan.",
                        HorsePower = 220.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2010
                    },
                    new Car()
                    {
                        BrandId = mazdaId,
                        Description = "The Mazda Bongo is a van.",
                        HorsePower = 128.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 1996
                    },
                    new Car()
                    {
                        BrandId = mazdaId,
                        Description = "The Mazda RX-7 is a sports car.",
                        HorsePower = 182.0,
                        ImporterId = asianVehiclesId,
                        YearManufactured = 2001
                    }
                };

                foreach (var car in cars)
                {
                    context.Cars.Add(car);
                }

                context.SaveChanges();
            }
        }

        private IEnumerable<Importer> LoadImporters(ICarsSearchDbContext context)
        {
            var importers = new List<Importer>()
            {
                new Importer() { Name = "Happy Cars" },
                new Importer() { Name = "Nice & Cheap" },
                new Importer() { Name = "Bella Italia" },
                new Importer() { Name = "German Automotion" },
                new Importer() { Name = "The French Connection" },
                new Importer() { Name = "Asia's Finest" },
                new Importer() { Name = "American Daydreams" },
            };

            foreach (var importer in importers)
            {
                context.Importers.Add(importer);
            }

            context.SaveChanges();

            return importers;
        }

        private IEnumerable<Brand> LoadBrands(ICarsSearchDbContext context)
        {
            var brands = new List<Brand>()
            {
                new Brand() { Name = "Audi" },
                new Brand() { Name = "BMW" },
                new Brand() { Name = "Dacia" },
                new Brand() { Name = "Fiat" },
                new Brand() { Name = "Volkswagen" },
                new Brand() { Name = "Mercedes" },
                new Brand() { Name = "Renault" },
                new Brand() { Name = "Peugeot" },
                new Brand() { Name = "Volvo" },
                new Brand() { Name = "Dodge" },
                new Brand() { Name = "Ford" },
                new Brand() { Name = "Toyota" },
                new Brand() { Name = "Honda" },
                new Brand() { Name = "Mazda" }
            };

            foreach (var brand in brands)
            {
                context.Brands.Add(brand);
            }

            context.SaveChanges();

            return brands;
        }
    }
}