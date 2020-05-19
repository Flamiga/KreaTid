using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kreaTid.Models;

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
<<<<<<< Updated upstream
                new Category { CategoryId = 2, CategoryName = "Tegning" },
                new Category { CategoryId = 3, CategoryName = "Maling" },
=======
                new Category { CategoryId = 2, CategoryName = "Maling" },
                new Category { CategoryId = 3, CategoryName = "Tegning" },
>>>>>>> Stashed changes
                new Category { CategoryId = 4, CategoryName = "Tilbehør" }
                );


            //mangler vores lister fra product img og productcomments
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Maling", ProductPrice = 23.00m, ProductDescription = "bla bla bla", CategoryId = 1 },
                new Product { ProductId = 2, ProductName = "kl", ProductPrice = 23.00m, ProductDescription = "bla bla bla", CategoryId = 2 },
                new Product { ProductId = 3, ProductName = "Maling", ProductPrice = 23.00m, ProductDescription = "bla bla bla", CategoryId = 3 },
                new Product { ProductId = 4, ProductName = "Maling", ProductPrice = 23.00m, ProductDescription = "bla bla bla", CategoryId = 1 });

            //ændre DateTime til New datetime se side 15 fra exercises L09
            modelBuilder.Entity<ProductComment>().HasData(
                new ProductComment { ProductCommentId = 1, ProductCommentDate = DateTime.Now, ProductCommentUser = "", ProductCommentText = "", ProductCommentLastUpdated = DateTime.Now, ProductId = 1, });

            modelBuilder.Entity<ProductImg>().HasData(
            new ProductImg { ProductImgId = 1, ProductImgAltText = "test", ProductImgType = "productImg", ProductImgFileUrl = "~/img/Logo.png", });

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
               new BlogPostImg { BlogPostImgId = 1, ImgAltText = "ddd", ImgFileUrl = "~/img/header.jpg", ImgType = "blogbillede", BlogPostId = 1 }
                );

        }

    }

}

