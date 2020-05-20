using kreaTid.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace kreaTid.Data
{
    public class kreaTidContext : DbContext
    {
        public kreaTidContext(DbContextOptions<kreaTidContext> options)
            : base(options)
        {
        }

        public DbSet<BlogPost> BlogPost { get; set; }

        public DbSet<BlogPostComment> BlogPostComment { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<BlogPostImg> BlogPostImg { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<ProductComment> ProductComment { get; set; }

        public DbSet<ProductImg> ProductImg { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Products
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<ProductComment>().ToTable("ProductComment");
            modelBuilder.Entity<ProductImg>().ToTable("ProductImg");
            modelBuilder.Entity<Product>().ToTable("Product");

            //Blog Post
            modelBuilder.Entity<BlogPostComment>().ToTable("BlogPostComment");
            modelBuilder.Entity<BlogPost>().ToTable("BlogPost");
            modelBuilder.Entity<BlogPostImg>().ToTable("BlogPostImg");

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Papir" },
                new Category { CategoryId = 2, CategoryName = "Maling" },
                new Category { CategoryId = 3, CategoryName = "Tegning" },
                new Category { CategoryId = 4, CategoryName = "Tilbehør" }
                );


            //mangler vores lister fra product img og productcomments
            modelBuilder.Entity<Product>().HasData(
                //Products for blog post 1 (viskelædere)
                new Product { ProductId = 1, ProductName = "GRENE viskelæder", ProductPrice = 0.98m, ProductDescription = "Sommetider skal der små justeringer til for at opnå det ønskede resultat, mener søstrene. GRENE har derfor kreeret dette nydelige viskelæder, der let udvisker blyantspor. Et viskelæder er vidunderligt til at korrigere detaljer, som De ikke helt blev tilfreds med. Et særdeles anvendeligt redskab til kontoret.", CategoryId = 4 },
                new Product { ProductId = 2, ProductName = "Steadtler Mars Plastic viskelæder", ProductPrice = 25.00m, ProductDescription = "Viskelæder af højeste kvalitet til alle typer af blyanter, grafitlinjer og farveblyanter.", CategoryId = 4 },
                new Product { ProductId = 3, ProductName = "Farber-Castell Dust-Free viskelæder", ProductPrice = 19.95m, ProductDescription = "Viskelæder dust-free, fra Faber-Castell.Hvid - 63 x 22 x 12 mm.Ekstra blødt viskegummi. Til blyanter med bløde stifter.", CategoryId = 4 },
                //Products for blog post 2 (markers)
                new Product { ProductId = 4, ProductName = "Design Twin Markers 12 stk. Standart sæt", ProductPrice = 169.95m, ProductDescription = "Design Twin markers er en smart og enkelt 2-i-1 markers til dine tegninger og illustrationer. Sættet med 12 standardfarver giver dig en god base og grundlag for dine designs. Brug sættet sammen med mange af vores andre Design Twin markers og giv liv til dine tegninger og illustrationer. Med et standardsæt af 12 farver får du farver der dækker dit basisbehov. Med en tyk og en tynd ende kan du variere dine streger og derved er der endnu flere muligheder i de 12 markers. Brug begge ender og skab flotte motiver og designs.Den tynde ende måler 1,5 mm og den tykke ende måler 7,0 mm.", CategoryId = 3 },
                new Product { ProductId = 5, ProductName = "Touch Twin Marker", ProductPrice = 39.00m, ProductDescription = "Touch Twin Brush Marker er en alkoholbaseret tusch, der er tilgængelig i 204 farver. To spidser, en med penselspids(brush tip) i den ene ende og en bred spids(Chisel tip) i den anden. Spidserne kan udskiftes. Den halvtransparente tusch lægges i lag og gør det nemt at lave bløde toner og overgange. Produktet er velegnet til hobbyfolket såvel som illustratorer og designere. Vi anbefaler at supplere med en farveløs blender og markerpapir.", CategoryId = 3 },
                new Product { ProductId = 6, ProductName = "Copic Ciao", ProductPrice = 49.00m, ProductDescription = "Copic Ciao er den perfekte ud af Copic's tusser til nybegyndere, elever, studerende og amatørkunstnere, og prisen er yderst rimelig. Permanent, giftfrit, syrefrit og alkoholbaseret blæk, som er hurtigtørrende. Pennen har to standardspidser, en mediumbred i den ene ende, og pensel i den anden. Hætten er farvet, så du hurtigt kan vælge farve.", CategoryId = 3 },
                //Products for blog post 3 (soft pastel)
                new Product { ProductId = 7, ProductName = "Rembrandt Soft Pastel Half Stick Set", ProductPrice = 120.00m, ProductDescription = "Et sæt på 10 halve stick bløde pasteller fra Royal Talens Rembrandt professionelle sortiment. Pasteller er en blød kridtype baseret på kaolin (porcelæn) og pigment, hvormed tegninger kan laves i en stil, der ligner maleri. Kunstnere, der arbejder med pasteller, har en tendens til at se deres arbejde som et maleri snarere end en tegning. Disse pasteller tilbyder fremragende farveudgivelse og intense, rene farver. De har en god grad af lysfasthed og meget høj farvekraft på grund af den høje koncentration af pigment. Rembrandt bløde pasteller skylder deres kvalitet til det tætte samarbejde med professionelle kunstnere kombineret med traditionel ekspertise og mere end et århundredes erfaring med pastelfabrikation. Hver farve er lavet efter en unik formel, og de nødvendige råvarer gennemgår meget strenge kontroller for hver nye batch.", CategoryId = 3 },
                new Product { ProductId = 8, ProductName = "Bruynzeel Design Pastel Pencil", ProductPrice = 20.00m, ProductDescription = "Bruynzeel Design Pastel Pencils er designet nøjagtigt til kunstneres, designere og illustratørers behov. Disse pastelblyanter i høj kvalitet er udformet med de fineste lysfaste pigmenter og Kaolin-ler. De 3,7 mm brede målere, perfekt centrerede og dobbeltlimede farvede kerner kombineres med de fineste lette cedertræk for at gøre dem meget modstandsdygtige over for brud. De holder også et punkt bedre end de fleste pastelflyanter og er en glæde at skærpe", CategoryId = 3 },
                new Product { ProductId = 9, ProductName = "Canson Mi-Teintes Touch Paper", ProductPrice = 199.95m, ProductDescription = "Canson Mi-Teintes Touch Paper er det ultimative papir til pastelkridt med en ru overflade der minder om fint sandpapir. Overfladen får kul, pastel, kridt og akryl til at fremtræde smukt på papiret, og bevarer pastelpigmenterne hvilket gør det muligt at male i flere lag.", CategoryId = 1 },
                //Products for blog post 4 (gouache)
                new Product { ProductId = 10, ProductName = "Daler Rowney Aquafine Gouache", ProductPrice = 36.00m, ProductDescription = "Denne farvepakke er en ideel introduktion til Aquafine Gouache akvarelfarver. Aquafine-akvareller er lavet af et omhyggeligt udvalg af moderne højkvalitetspigmenter, der er formalet til perfektion for at give optimal ydelse og kontrol. Disse rige farver har smuk pigmentering og egenskaber, der producerer smukke, sarte vaske hver gang. Disse malinger kombinerer en moderne måde at bruge akvarel på med de traditionelle essentials, der følger med at bruge dette medium, hvilket gør dette innovative sortiment ideelt til blandede medier såvel som traditionelle teknikker.", CategoryId = 2 },
                new Product { ProductId = 11, ProductName = "Lyra Robinson 3B Pencil", ProductPrice = 24.95m, ProductDescription = "Dette er en fremragende træ- og blyblyant fra Lyra. Disse blyanter bliver hurtigt et meget populært tegningsprodukt på grund af deres høje kvalitet og deres pålidelige brug. Det er et meget smart tegneinstrument med en højglans blå farve, en farvet dyppet ende og guldprægede sortering. Det giver bestemt en god tilføjelse til din blyantkollektion og den bløde kerne giver en dejlig mørk linje.", CategoryId = 3 },
                new Product { ProductId = 12, ProductName = "Royal Talens Van Gogh 191 Series Brush", ProductPrice = 45.00m, ProductDescription = "Van Gogh børster er lavet med yderste omhu og håndværk. Denne 191-serie (nr. 6) er en rund børste lavet med gyldent syntetisk hår af høj kvalitet. Den fine spids gør den god til kontrolleret detalje, men med lidt tryk kan der frembringes dristige tykke slag. De fleksible og stærke børster gør den modstandsdygtig over for slid, så den er en fantastisk børste til daglig brug. Det er også designet med en stor hårtæthed, så det kan rumme en stor mængde maling, hvilket gør det til det perfekte instrument til gouache-akvarelmalning.", CategoryId = 4 },
                new Product { ProductId = 13, ProductName = "KUM Natural Eraser", ProductPrice = 15.00m, ProductDescription = "Dette enkle viskelæder i høj kvalitet kan fjerne de fleste blyantlinjer uden at forårsage grimme udtværinger, udtværing eller blødning. Det er lavet af et kvalitetsmateriale, der er blødt og blidt, hvilket sikrer, at der ikke er unødvendig belastning på dit papir. Det er ekstremt alsidigt og kan bruges på en række forskellige overflader, såsom papir, pap og træ. KUM viskelædet er også lavet af naturlige materialer, så det er fri for PVC, latex og ftalater.", CategoryId = 4 },
                new Product { ProductId = 14, ProductName = "Bockingford CP Watercolour Paper 220gsm", ProductPrice = 23.00m, ProductDescription = "Et meget populært vandfarvepapir, der er meget absorberende, med et smukt struktureret udseende. Det fremstilles traditionelt på St Cuthberts Mølle ved hjælp af en høj alfa-cellulose. Det har en attraktiv overflade, der er skabt ved hjælp af naturlige uldfilt, hvilket giver papiret en smukt tekstureret finish, der er meget stabil og med fremragende farveopløftningsevner.", CategoryId = 1 },
                //Products for blog post 5 (mal med de så pour painting)
                new Product { ProductId = 15, ProductName = "ArtistLine Canvas 30x30cm", ProductPrice = 35.00m, ProductDescription = "Grundmalet, ubleget bomuldslærred i superkvalitet. Opspændt på blindramme med sømfri kant, hæftet på bagsiden. str. 30x30 cm, dybde 1,6 cm,360 g", CategoryId = 1 },
                new Product { ProductId = 16, ProductName = "Pouring-Fluid 150ml", ProductPrice = 47.00m, ProductDescription = "Akryl- og vandbaseret klar medie, som blandes med akryl- eller hobbymaling for at gøre malingen mere flydende og dermed velegnet til diverse fluid painting/acrylic pouring teknikker. Kan også anvendes ufortyndet som en transparent.Tørrer blankt og vandfast op og gulner ikke.", CategoryId = 2 },
                new Product { ProductId = 17, ProductName = "Plus Color hobbymaling, black, 60ml", ProductPrice = 24.95m, ProductDescription = "Vandbaseret hobbymaling i rigtig god kvalitet med høj farvepigmentering, der giver en god dækkeevne. Tørrer hurtigt op og efterlader en silkemat overflade. Velegnet til træ, pap, gips osv..", CategoryId = 2 },
                new Product { ProductId = 18, ProductName = "Ispinde", ProductPrice = 17.00m, ProductDescription = "Ispinde lyst træ midi, L: 11,5 cm, B: 10 mm, birk, 30stk", CategoryId = 4 },
                //Products for blog post 6 (Påske)
                new Product { ProductId = 19, ProductName = "Karton A4 10stk.", ProductPrice = 19.95m, ProductDescription = "Flere farver, A4 210x297 mm, 220 g, 10stk.", CategoryId = 1 },
                new Product { ProductId = 20, ProductName = "White limstift, 21 g, 1stk.", ProductPrice = 23.00m, ProductDescription = "Hvid limstift i rigtig god kvalitet til karton, papir m.m. 21 g. Tørrer klart op.", CategoryId = 4 },
                new Product { ProductId = 21, ProductName = "Silhuetsaks", ProductPrice = 32.00m, ProductDescription = "L: 11 cm, højre, 1stk.", CategoryId = 1 },
                //Products for blog post 7 (Posca)
                new Product { ProductId = 22, ProductName = "Posca Tusch 2,5mm", ProductPrice = 23.00m, ProductDescription = "Stregtykkelse: 2,5 mm, PC-5M , medium, 1stk.", CategoryId = 3 },
                //Products for blog post 8 (Bullet journey)
                new Product { ProductId = 23, ProductName = "LEUCHTTURM1917 Bullet Journal (dotted)", ProductPrice = 180.00m, ProductDescription = "Bullet Journal fra tyske LEUCHTTURM1917 henvender sig til dig, som synes, at der ikke er noget mere herligt end at organisere livet på en kreativ og pæn måde. Punktmønstret papir. Størrelse: A5. Indeholder en guide til Bullet Journaling", CategoryId = 1 },
                new Product { ProductId = 24, ProductName = "Handlettering - 1000 dekorative ideer", ProductPrice = 149.95m, ProductDescription = " Hand Lettering 1.000 dekorative idéer er for alle - fra nybegyndere til øvede. Bogen er fuld af overskuelige  vejledninger, så man nemt lærer de grundlæggende teknikker. Du får masser DIY's, øvelser og tips, så du selv som nybegynder kan være med. Bogen indeholder masser af inspirerende eksempler, som bl.a. kan bruges i bullet journals. Denne bog er både et opslagsværk, en inspirationskilde med masser af idéer og en guldgrube af dekorative elementer. Str. 22x23 cm, tykkelse 2 cm, dansk tekst 143 sider.", CategoryId = 4 },
                new Product { ProductId = 25, ProductName = "Hand Lettering Øvehæftet til Grundbogen", ProductPrice = 79.95m, ProductDescription = "Hand Lettering er håndtegnede og smukt dekorerede ord og statements. Skab selv unikke og personlige fødselsdagskort og indbydelser, lav fine mærkater og skilte eller sæt dit eget præg på alt fra t-shirts, tasker, porcelæn og glas til billeder og tavler. Dette øvehæfte giver dig rig mulighed for at lære, hvordan flotte bogstaver og illustrationer som kranse, blomster, bånd og krummelurer bygges op og guider dig igennem trin for trin vejledninger. Du får masser af DIY´s, idéer, tips og tricks, der motiverer dig til at tage blyanten i hånden og komme i gang. Efter lidt øvelse kan du kreere dekorative kunstværker  og glæde dig selv, familie og venner med din personlige streg.Alt, du skal bruge for at komme i gang, er blyant, viskelæder, lineal og fineliner, så er du klædt på til mange timers fordybelse.Prøv også at farvelægge eksemplerne og illustrationerne i bogen og nyd at lege med forskellige farvekombinationer.", CategoryId = 4 },
                new Product { ProductId = 26, ProductName = "Fine Line skrive/tegnetusch", ProductPrice = 125.00m, ProductDescription = "Sortiment af tusch, der er alkoholbaserede og lysægte - hver med rund, fin tegnespids. Stregtykkelse: 0,03mm, 0,05mm, 0,1mm, 0,2mm, 0,3mm, 0,5mm, 0,8mm, og 1,0 mm, sort, 8stk.", CategoryId = 3 });
                

            //ændre DateTime til New datetime se side 15 fra exercises L09
            modelBuilder.Entity<ProductComment>().HasData(
                new ProductComment { ProductCommentId = 1, ProductCommentDate = DateTime.Now, ProductCommentUser = "", ProductCommentText = "", ProductCommentLastUpdated = DateTime.Now, ProductId = 1, });

            modelBuilder.Entity<ProductImg>().HasData(
            //Product images for products connected to blog post 1
            new ProductImg { ProductImgId = 1, ProductImgAltText = "GRENEviskelæder", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/GRENEviskelæder.jifi", ProductId = 1 },
            new ProductImg { ProductImgId = 2, ProductImgAltText = "test", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/steadtler-mars-plastic.jifi", ProductId = 2},
            new ProductImg { ProductImgId = 3, ProductImgAltText = "faber-castell-dust-free-eraser", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/faber-castell-dust-free-eraser.jpg", ProductId = 3},
            //Product images for products connected to blog post 2
            new ProductImg { ProductImgId = 4, ProductImgAltText = "Design Twin Markers", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/design-twin-marker-pastel-SingleView.jpg", ProductId = 4 },
            new ProductImg { ProductImgId = 5, ProductImgAltText = "Design Twin Markers", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/DesignTwinMarkerSideView.PNG", ProductId = 4},
            new ProductImg { ProductImgId = 5, ProductImgAltText = "Design Twin Markers", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/DesignTwinMarker.PNG", ProductId = 4},

            new ProductImg { ProductImgId = 6, ProductImgAltText = "Copic Ciao", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/copic_ciao_styckvis.jpg", ProductId = 6},
            new ProductImg { ProductImgId = 7, ProductImgAltText = "Copic Ciao udvalgte farver", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/copic_ciao_styckvis.png", ProductId = 6},

            new ProductImg { ProductImgId = 8, ProductImgAltText = "Touch Twin Marker, enkel", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/touchtwinmarker_singleview.png", ProductId = 5 },
            new ProductImg { ProductImgId = 9, ProductImgAltText = "Touch Twin Marker, 12 stk sæt", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/TouchTwinMarker12stk.jpg", ProductId = 5 },

            //Product images for products connected to blog post 3
            new ProductImg { ProductImgId = 10, ProductImgAltText = "test", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/Rembrandt-Soft-Pastel-Half-Stick-10-Set_250x.jpg", ProductId = 7 },

            new ProductImg { ProductImgId = 11, ProductImgAltText = "test", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/Bruynzeel-design-pastel-pencil.jpg", ProductId = 8},

            new ProductImg { ProductImgId = 12, ProductImgAltText = "Canson Mi Teintes Touch", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/canson_mi_teintes_touch", ProductId = 9},
            //Product images for products connected to blog post 4
            new ProductImg { ProductImgId = 13, ProductImgAltText = "Daler Rowney Gouache Opaque Watercolour Paint", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/Daler-Rowney-Gouache-Opaque-Watercolour-Paints.jpg", ProductId = 10 },

            new ProductImg { ProductImgId = 14, ProductImgAltText = "Lyra-Robinson-3B-Pencil", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/Lyra-Robinson-3B-Pencil_250x.jpg", ProductId = 11},

            new ProductImg { ProductImgId = 15, ProductImgAltText = "RoyalTalens-VanGogh-191-Series-No6-Brush", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/RoyalTalens-VanGogh-191-Series-No6-Brush_250x.jpg", ProductId = 12 },

            new ProductImg { ProductImgId = 16, ProductImgAltText = "KUM natural viskelæder", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/KUM-natural-eraser_250x.jpg", ProductId = 13 },

            new ProductImg { ProductImgId = 17, ProductImgAltText = "Bockingford Block", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/BockingfordBlock.jpg", ProductId = 14 },

            //Product images for products connected to blog post 5
            new ProductImg { ProductImgId = 18, ProductImgAltText = "30x30 cm lærred", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/Lærred.jpg", ProductId = 15 },

            new ProductImg { ProductImgId = 19, ProductImgAltText = "Pouring Fluid", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/Pouring-Fluid.jpg", ProductId = 16 },

            new ProductImg { ProductImgId = 20, ProductImgAltText = "hobby maling sort", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/hobby-maling-sort.jpg", ProductId = 17},

            new ProductImg { ProductImgId = 21, ProductImgAltText = "Ispinde", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/ispinde.jpg", ProductId = 18 },

            //Product images for products connected to blog post 6
            new ProductImg { ProductImgId = 22, ProductImgAltText = "Karton", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/karton-lysblå.jpg", ProductId = 19},
            new ProductImg { ProductImgId = 23, ProductImgAltText = "Lim", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/lim.jpg", ProductId = 20 },
            new ProductImg { ProductImgId = 24, ProductImgAltText = "Saks", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/saks.jpg", ProductId = 21 },

            //Product images for products connected to blog post 7
            new ProductImg { ProductImgId = 25, ProductImgAltText = "posca", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/posca2.5mm.jpg", ProductId = 22},
             new ProductImg { ProductImgId = 26, ProductImgAltText = "Posca sæt 10stk", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/POSCAset.jpg",ProductId = 22},
            new ProductImg { ProductImgId = 27, ProductImgAltText = "Sten tegnet med POSCA", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/monstersten_1.jpg", ProductId = 22},

            //Product images for products connected to blog post 8
            new ProductImg { ProductImgId = 28, ProductImgAltText = "Leuchturm1917 Dotted", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/notebogA5.jpg", ProductId = 23},
            new ProductImg { ProductImgId = 29, ProductImgAltText = "Hand Lettering 1000 exercises", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/Hand Lettering1000exercises.jpg", ProductId = 24},
            new ProductImg { ProductImgId = 30, ProductImgAltText = "handlettering exercises paper", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/handletteringexercisespaper.jpg", ProductId = 25},
            new ProductImg { ProductImgId = 31, ProductImgAltText = "fine liners", ProductImgType = "productImg", ProductImgFileUrl = "~/img/varer/fineliner.jpg", ProductId = 26});

            //mangler vores lister fra vores billeder og comments. HUSK INDSÆT ANDRE DATOER!!!
            modelBuilder.Entity<BlogPost>().HasData(
            new BlogPost { BlogPostId = 1, BlogPostTitle = "Bedste viskelæder til dit behov", BlogPostContent = "<p>Viskelæderet, et af tegnerens vigtige redskaber. Men er viskelæder ikke bare et viskelæder? Hvis du tænker det er så nemt må vi desværre skuffe dig. Jo hvis du bare skal viske noget ud hurtigt, kan et almindeligt viskelæder godt bruges. Men når du arbejder på et projekt og du lige skal rette noget ville det så ikke være ærgerligt hvis blyanten blot blev tværet ud eller den lineart (linjerne i tegning ofte tegnet op med en form for blæk pen) du har brugt timer på delvist forsvinder eller bliver ødelagt når du visker skitsen under ud? Vi synes det er ærgerligt at gå på kompromi så vi har kigget på et udvalg af viskelædere og sammenlignet dem for at hjælpe dig med at vælge lige den der passer til dit behov. </p><p> Den første er det klassiske Staedler mars plastic viskelæder. Som det kan ses på billedeter det godt til blyant tager lidt blæk med og ødelægger lidt farveblyanten. </p><p> Det næste er et billigt GRENE viskelæder. Denne klare sig ikke helt lige så godt som Steadler Mars. </p><p> Den sidste er Faber - Castell ‘Dust - free’. Dette er ikke helt støvfri men producerer en del mindre støv end de andre viskelædere.</p><p>Alt i alt Er Faber - Catell godt hvis man er træt af støv, GRENE godt hvis man bare vil have en billigt løsning og Steadler godt hvis man ikke har noget imod at skulle fjerne støvet.Du kan selv prøve dem af hvis du vil se det med dine egne øjne.</p>", BlogPostDate = DateTime.Now },
            new BlogPost { BlogPostId = 2, BlogPostTitle = "Hvilken marker er bedst til dig", BlogPostContent = "<p>Der findes mange forskellige mærker af markers og det kan være svært at vide hvad der er bedst. Så her sammenligner vi 3 mærker af markers og giver vores anbefalinger til dig om hvad de er gode til.</p><p>Den første er Design Twin Markers.En af de billigere muligheder derude.De har et godt udvalg af farver.De har en spids i hver ende.En bullet tip i den ene til mere præcis.En chisel tip i den anden ende til større områder.Kvaliteten er god.</ p >< p >Den næste vi har kigget på er er Touch Twin Markers.Har et godt farveudvalg.Ligesom Design Twin Markers har de to spiser.Den ene værende den brede chisel tip og den anden værende en Brush tip.Brush tip er mere fleksible og giver større variation i de linjer man kan lave med dem.De gør det nemt at lave fine detaljer og farvelægge lidt større områder nemt og hurtigt.De har god blæk der en god enshed.</ p >< p >Sidst kiggede vi på Copic.Et af de mest kendte mærker, men også en af de dyreste.Det er et mærke ofte brugt af professionelle.Copic fås i forskellige slags Original, Sketch og Ciao.Vi har valgt at fokusere på Ciao den billigste version som er god hvis man har lyst at prøve copic uden at skal tømme lommerne helt.De har dog også mindre blæk i sig.Copic Ciao har også chisel og brush tips.God kvalitet blæk med jævn fordeling.</ p >< p > Design Twin Markers er gode som er billigere mulighed hvis ikke Brush tip er noget man er interesseret i.Touch Twin Markers er lidt dyrerer, men en godt bud hvis du gerne vil prøve at arbejde med brush markers uden at skulle investerer helt vildt stort.Sidst Copic Ciao godt til at prøve Copic og begynde i det mere professionelle, men hvis du allerede ved du vil komme til at bruge dem meget  kan den hurtigt blive en fordel at vælge Sketch versionen da disse kan genopfyldes.</ p >< p > Nu kan de vælge bedre efter behov eller teste dem alle og se hvad der passer dig bedst.</p>", BlogPostDate = DateTime.Now },
            new BlogPost { BlogPostId = 3, BlogPostTitle = "Prøv soft pastel", BlogPostContent = "<p>Man må omfavne rod og kaos, når man arbejder med soft pastel. Kunstner Marlene Rye har vist os har hvad man kan opnå med de støvende farver.Med brug af soft pastel, pastelblyanter og pastel venlige Canson Mi - Teintes Touch Papir har hun skabt et smukt landskab. </p><p>Tegn med pastel på papiret de store figure og farve felter fra dit motiv.Gem de fine detaljer til senere.Du vil sandsynligvis kunne se noget af papiret igennem farverne.Detaljer kan være svære at opnå med soft pastel så fortvivl ikke hvis det ikke ligner helt!</p><p>Når farverne er på plads kan du bruge en finger til at blande farverne.Du kan også bruge et stykke køkkenrulle for at få mindre på fingerne.Nu skulle du have skabt en mere solid farve med mindre papir synligt.Mangler der farve nogle steder ? Tilføj mere og bland eller blend med fingre eller papir igen.</p><p>Så det tid til detaljer! Brug kanterne af soft pastel stykkerne og eller supplimenter med pastelblyanterne og tegn detaljerne ind.Blend ikke her for at behold de skarpeste detaljer. Gennemgå til du er tilfreds eller mere farve ikke vil hænge ved papiret og prøv et nyt motiv eller det samme igen og se om det er nemmere denne gang.Måske du opdager din helt egen måde og rækkefølge at bruge materialerne i.Skitse med blyanter først evt. for nemmere at fylde farverne ind eller brug udelukkende soft pastel stykker i stor bløde strøg.Der er mange måder at gøre det på.</p><p>Marlene Rye har udvalgt farverne og materialerne hun selv har brugt i billedet.Prøv dem selv af og få inspiration fra de ørken inspirerede farver og hendes fantastiske eksempel på brugen af dem.</p><h3>Om Kunstneren:</h3><p>Marlene Rye har en A.B.fra Smith College og en M.F.A.fra University of Pennsylvania.Hun har studeret under Andrew Forge, Barbara Grossman, John Moore og Martha Armstrong.Hendes arbejde er blevet vist nationalt og er blevet accepteret til bedømte shows med højtstående konservatorer fra Whitney Museum of American Art og Guggenheim.Hun har haft 20 solo - shows siden 1994.</ p >< p >Instagram: @marlenerye_art <br>Facebook: Marlene Rye Art <br>Website: <a href='www.MarleneRye.com' terget='_blank' > www.MarleneRye.com </a></p>", BlogPostDate = DateTime.Now },
            new BlogPost { BlogPostId = 4, BlogPostTitle = "Ny med gouache", BlogPostContent = "<p>Oplev kompleksiteten af menneskets følelser med kunstneren Riso Chan når du bruger disse omhyggeligt udvalgte farve palette af Daler Rowney Aquafine Gouache.</p><p>Riso Chan demonstrarer hvordan hun bruger disse nemt og simplet.</p><p>Skitser et motiv på et stykke papir med nogen vægt.f.eks.Bockingford CP Watercolour Paper(220gsm).Mal derefter med penslen.Gouachen er vandbaseret så du kan fortynde det med vand og få endnu mere ud af farverne.</p><p>Start evt.ud med et tyndere vand for tyndt lag i de lys områder.Det første lag behøver ikke være perfekt da gouache ikke er gennemsigtig og du kan lægge et lag farve oven på.Husk dog at jo mere vand det er blandet med jo mere gennemsigtig vil det være.</p><p>Fortsæt med at bygge lagene op med mere eller mindre vand i gouachen eller måske bare helt direkte fra tuben.</p><p>Riso Chan har udarbejdet et eksempel på en et emotionelt ansigt med disse materialer.Prøv selv kræfter med dem.Male et ansigt med følelserne vist i både farver og udseende.Tag inspiration fra Riso Chans billede og udforsk følelser.Hvem vil du male og hvad føler de!</p><p><h3>Om Kunstneren:</h3><p>Riso Chan er en kunstner og kreativ lærer med base i Amsterdam.Hun voksede op i et kunstnerisk miljø, hvor hendes mor var billedhugger, der inspirerede hende til at udforske sin egen kreativitet fra en tidlig alder.Hun mener, at portrætter kan være en meget kraftig måde at udtrykke følelser og menneskelig skønhed på.Det er et sprog på egen hånd, der ikke bruger ord til at kommunikere, det er derfor, det meste af hendes arbejde drejer sig om portrætter.Riso arbejder hovedsageligt med akvarel og gouache, skønt hun også sommetider eksperimenterer med digitalt maleri.</p><p>Instagram - @risochan</p>", BlogPostDate = DateTime.Now },
            new BlogPost { BlogPostId = 5, BlogPostTitle = "Mal med de små", BlogPostContent = "<p>I disse indelukkede dage kan det være svært at få tiden til at gå. Men hvorfor ikke bruge tiden med de små i hjemmet og lav noget nyt pynt til væggene? I disse indelukkede dage kan det være svært at få tiden til at gå. Men hvorfor ikke bruge tiden med de små i hjemmet og lav noget nyt pynt til væggene?</p><p>Med Pouring-Fluid og hobbymaling kan man lave flotte abstrakte værker med marmoreringseffekt.Prøv det selv med disse trin.</p><p>TRIN 1. Læg alle materialerne frem: Lærred, maling, Pouring-Fluid, plastkrus, rørepinde/ispinde, gummihandsker, underlag og noget, der hæver lærredet op fra underlaget.</p><p>Hver opmærksom på at 150 ml Pouring-Fluid er lige akkurat nok til et lærred på 30 x 30 cm.</p><p>TRIN 2. Hæld lidt af hver farve maling du vil bruge op i hvert sit krus. Hæld Pouring-Fluid oveni. Blandingen skal være så flydende, at den løber.</p><p>TRIN 3. Rør så malingen og Pouring-Fluid bliver godt blandet.</p><p>TRIN 4.Tag et nyt krus og hæld den hvide blanding i først. Hæld derefter en anden farve ned i midten. Efterfølgende hælder du en tredje farve ned i midten.TRIN 5.Stik forsigtigt rørepinden ned midt i og træk farven ud i siden.</p><p>TRIN 6.Læg lærredet ovenpå kruset og vend det hele, så lærredet ender nederst.</p><p>TRIN 7.Løft kruset så al malingen løber ud.</p><p>TRIN 8. Løft lærredet og vip det til siderne, så malingen løber.</p><p>TRIN 9.Hæld flere farveblandinger i kruset, gerne flere forskellige farver, og fortsæt til lærredet er dækket. Lad det også løbe ned ad siderne.</p><p>TRIN 10.Mal linjer på maleriet ved at hælde en ren farveblanding på.</p><p>TRIN 11.Bland evt. en fjerde farve med (her er brugt blå).</p><p>TRIN 12.Løft lærredet igen og lad farverne løbe til du er tilfreds. Vær opmærksom på at farverne løber lidt videre af sig selv, når du lægger lærredet ned igen. Lad værket tørre i mindst 24 timer</p><p>Nu har i laver et flot værk der kan hænges på vægge og give nyt liv i rummet. </p>", BlogPostDate = DateTime.Now },
            new BlogPost { BlogPostId = 6, BlogPostTitle = "Gækkebrev med påskekylling", BlogPostContent = "<p>Klip flotte gækkebreve med detaljerede mønstre af påskekyllinger og påskeliljer. Du kan klippe ud fra gækkebrev skabelonerne, du finder her på siden eller lave dine egne flotte designs.</p><p><h3>Step 1.</h3><p>Find evt.gækkebrev skabelonerne, og klip omridset af skabelonen ud.</p><h3>Step 2.</h3><p>Fold et A4 papir efter anvisningen på kabelonarket.Vær opmærksom på at hjørnerne mødes, så gækkebrevet kan foldes ud.Sæt skabelonen fast med clips og klip med en god, spids saks.</p><h3>Step 3.</h3><p>Line op med kanterne og lim fast til karton. Flere version som du har løst. Så kan du sende det til bedsteforældrene eller vennerne og håbe de ikke kan gætte det.</p> ", BlogPostDate = DateTime.Now },
            new BlogPost { BlogPostId = 7, BlogPostTitle = "Posca på sten til nye have dekorationer", BlogPostContent = "<p>Med Posca tusch kan du tegne på sten med hobbymaling. Tuschen er dækkende og tørrer hurtigt - derfor er den helt perfekt at bruge til at male på sten.</p><h3>Trin 1</h3><p>Tegn og mal fine figurer og motiver på sten med Posca tuscher.</p><h3>Trin 2</h3><p>Giv evt.stenen en gang lak for at bevarer motiverne længere.</p><p>Der er mange måde motiver og materialer at bruge Posca tusserne med.</p>", BlogPostDate = DateTime.Now },
            new BlogPost { BlogPostId = 8, BlogPostTitle = "Start din bullet journal Rejse", BlogPostContent = "<p>Med en bullet journal kan du skrive noter, lave lister samt bruge den som kalender. En bullet journal bruges både til at give én overblik over det, man har gang i, men også som et afstressende øjeblik i hverdagen. Kom nemt i gang med brug af øvehæftet.</p><h3>Trin 1</h3><p>Skriv og tegn de lister kalendere eller aktivitets sporinger du vil.</p><h3>Trin 2</h3><p>Tilføj farver med dine tusser(ofte vandbaserede, da alkoholbaserede for det meste går igennem sidernes papir).</p><h3>Trin 3</h3><p>Øvehæftet gør det nemt at finde inspiration og skabe stemninger i bogen.</p><p>Mangler du mere inspiration? Der er masser af folk på nettet der giver tips og tricks til hvordan de laver deres bullet journal, men de vil altid være personlige for dem der bruger dem.Prøv det selv med vores samling af begyndervenlige bullet journal materialer.</p>", BlogPostDate = DateTime.Now });


            modelBuilder.Entity<BlogPostComment>().HasData(
                new BlogPostComment { BlogPostCommentId = 1, BlogPostCommentUser = "who", BlogPostCommentText = "what", BlogPostCommentPublishDate = DateTime.Now, BlogPostCommentLastUpdated = DateTime.Now, BlogPostId = 1 });


            modelBuilder.Entity<BlogPostImg>().HasData(
                //Images for blog post 1
               new BlogPostImg { BlogPostImgId = 1, ImgAltText = "Før viskelædere blev brugt", ImgFileUrl = "~/img/BlogBilleder/viskelædertest1.jpg", ImgType = "blogbillede", BlogPostId = 1 },
               new BlogPostImg { BlogPostImgId = 2, ImgAltText = "Efter steadler mars", ImgFileUrl = "~/img/BlogBilleder/viskelædertest2.jpg", ImgType = "blogbillede", BlogPostId = 1 },
               new BlogPostImg { BlogPostImgId = 3, ImgAltText = "Efter steadler mars og Grene", ImgFileUrl = "~/img/BlogBilleder/viskelædertest3.jpg", ImgType = "blogbillede", BlogPostId = 1 },
               new BlogPostImg { BlogPostImgId = 4, ImgAltText = "Alle viskelædre brugt", ImgFileUrl = "~/img/BlogBilleder/viskelædertest4.jpg", ImgType = "blogbillede", BlogPostId = 1 },
               //Images for blog post 2
               new BlogPostImg { BlogPostImgId = 5, ImgAltText = "Linje tykkelser og flade eksempler med de tre marker typer", ImgFileUrl = "~/img/BlogBilleder/markertest.jpg", ImgType = "blogbillede", BlogPostId = 2 },
               //Images for blog post 3
               new BlogPostImg { BlogPostImgId = 6, ImgAltText = "Break Away Heart by Marlene Rye", ImgFileUrl = "~/img/BlogBilleder/Marlene-Rye_Break-Away-Heart", ImgType = "Coverbillede", BlogPostId = 3 },
               new BlogPostImg { BlogPostImgId = 7, ImgAltText = "Fan eksemple på soft pastel brug", ImgFileUrl = "~/img/BlogBilleder/krinstikeks.jpg", ImgType = "blogbillede", BlogPostId = 3 },
               new BlogPostImg { BlogPostImgId = 8, ImgAltText = "Soft pastel marterialer", ImgFileUrl = "~/img/BlogBilleder/softpastelmaterials.jpg", ImgType = "blogbillede", BlogPostId = 3 },
               //Images for blog post 4
               new BlogPostImg { BlogPostImgId = 9, ImgAltText = "RisoChan Gouache Materialer", ImgFileUrl = "~/img/BlogBilleder/RisoChan-GouacheMaterialer,jpg", ImgType = "Coverbillede", BlogPostId = 4 },
               new BlogPostImg { BlogPostImgId = 10, ImgAltText = "Riso Chans Gouache maleri", ImgFileUrl = "~/img/BlogBilleder/risochan-web.jpg", ImgType = "blogbillede", BlogPostId = 4 },
               new BlogPostImg { BlogPostImgId = 11, ImgAltText = "Gouache marterialer", ImgFileUrl = "~/img/BlogBilleder/Gouachematerials.jpg", ImgType = "blogbillede", BlogPostId = 4 },
               //Images for blog post 5
               new BlogPostImg { BlogPostImgId = 12, ImgAltText = "pourpainting trin 1", ImgFileUrl = "~/img/BlogBilleder/pourpainting-1.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 13, ImgAltText = "pourpainting trin 2", ImgFileUrl = "~/img/BlogBilleder/pourpainting-2.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 14, ImgAltText = "pourpainting trin 3", ImgFileUrl = "~/img/BlogBilleder/pourpainting-3.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 15, ImgAltText = "pourpainting trin 4", ImgFileUrl = "~/img/BlogBilleder/pourpainting-4.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 16, ImgAltText = "pourpainting trin 5", ImgFileUrl = "~/img/BlogBilleder/pourpainting-5.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 17, ImgAltText = "pourpainting trin 6", ImgFileUrl = "~/img/BlogBilleder/pourpainting-6.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 18, ImgAltText = "pourpainting trin 7", ImgFileUrl = "~/img/BlogBilleder/pourpainting-7.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 19, ImgAltText = "pourpainting trin 8", ImgFileUrl = "~/img/BlogBilleder/pourpainting-8.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 20, ImgAltText = "pourpainting trin 9", ImgFileUrl = "~/img/BlogBilleder/pourpainting-9.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 21, ImgAltText = "pourpainting trin 10", ImgFileUrl = "~/img/BlogBilleder/pourpainting-10.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 22, ImgAltText = "pourpainting trin 11", ImgFileUrl = "~/img/BlogBilleder/pourpainting-11.jpg", ImgType = "blogbillede", BlogPostId = 5 },
               new BlogPostImg { BlogPostImgId = 23, ImgAltText = "pourpainting trin 12", ImgFileUrl = "~/img/BlogBilleder/pourpainting-12.jpg", ImgType = "Coverbillede", BlogPostId = 5 },
               //Images for blog post 6
               new BlogPostImg { BlogPostImgId = 24, ImgAltText = "clipart-1", ImgFileUrl = "~/img/BlogBilleder/clipart-1.jpg", ImgType = "blogbillede", BlogPostId = 6 },
               new BlogPostImg { BlogPostImgId = 25, ImgAltText = "clipart-2", ImgFileUrl = "~/img/BlogBilleder/clipart-2.jpg", ImgType = "Coverbillede", BlogPostId = 6 },
               new BlogPostImg { BlogPostImgId = 26, ImgAltText = "clipart-3", ImgFileUrl = "~/img/BlogBilleder/clipart-3.jpg", ImgType = "blogbillede", BlogPostId = 6 },
               //Images for blog post 7
               new BlogPostImg { BlogPostImgId = 27, ImgAltText = "Posca på sten", ImgFileUrl = "~/img/BlogBilleder/drawingsstone.jpg", ImgType = "Coverbillede", BlogPostId = 7 },
               new BlogPostImg { BlogPostImgId = 28, ImgAltText = "Posca på sten", ImgFileUrl = "~/img/BlogBilleder/monstersten_1.jpg", ImgType = "blogbillede", BlogPostId = 7 },
               //Images for blog post 8
               new BlogPostImg { BlogPostImgId = 29, ImgAltText = "Bullet journal", ImgFileUrl = "~/img/BlogBilleder/bulletjournal1.jpg", ImgType = "Coverbillede", BlogPostId = 8 },
               new BlogPostImg { BlogPostImgId = 30, ImgAltText = "Bullet journal", ImgFileUrl = "~/img/BlogBilleder/bulletjournal2.jpg", ImgType = "blogbillede", BlogPostId = 8 }
                );

        }

    }

}

