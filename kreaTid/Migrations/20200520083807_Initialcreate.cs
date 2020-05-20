using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kreaTid.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPost",
                columns: table => new
                {
                    BlogPostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogPostTitle = table.Column<string>(nullable: true),
                    BlogPostDate = table.Column<DateTime>(nullable: false),
                    BlogPostContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPost", x => x.BlogPostId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostComment",
                columns: table => new
                {
                    BlogPostCommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogPostCommentUser = table.Column<string>(nullable: true),
                    BlogPostCommentText = table.Column<string>(nullable: true),
                    BlogPostCommentPublishDate = table.Column<DateTime>(nullable: false),
                    BlogPostCommentLastUpdated = table.Column<DateTime>(nullable: false),
                    BlogPostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostComment", x => x.BlogPostCommentId);
                    table.ForeignKey(
                        name: "FK_BlogPostComment_BlogPost_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPost",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostImg",
                columns: table => new
                {
                    BlogPostImgId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgFileUrl = table.Column<string>(nullable: true),
                    ImgAltText = table.Column<string>(nullable: true),
                    ImgType = table.Column<string>(nullable: true),
                    BlogPostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostImg", x => x.BlogPostImgId);
                    table.ForeignKey(
                        name: "FK_BlogPostImg_BlogPost_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPost",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductComment",
                columns: table => new
                {
                    ProductCommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCommentUser = table.Column<string>(nullable: true),
                    ProductCommentText = table.Column<string>(nullable: true),
                    ProductCommentDate = table.Column<DateTime>(nullable: false),
                    ProductCommentLastUpdated = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComment", x => x.ProductCommentId);
                    table.ForeignKey(
                        name: "FK_ProductComment_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImg",
                columns: table => new
                {
                    ProductImgId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductImgFileUrl = table.Column<string>(nullable: true),
                    ProductImgAltText = table.Column<string>(nullable: true),
                    ProductImgType = table.Column<string>(nullable: true),
                    BlogPostId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImg", x => x.ProductImgId);
                    table.ForeignKey(
                        name: "FK_ProductImg_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BlogPost",
                columns: new[] { "BlogPostId", "BlogPostContent", "BlogPostDate", "BlogPostTitle" },
                values: new object[,]
                {
                    { 1, "<p>Viskelæderet, et af tegnerens vigtige redskaber. Men er viskelæder ikke bare et viskelæder? Hvis du tænker det er så nemt må vi desværre skuffe dig. Jo hvis du bare skal viske noget ud hurtigt, kan et almindeligt viskelæder godt bruges. Men når du arbejder på et projekt og du lige skal rette noget ville det så ikke være ærgerligt hvis blyanten blot blev tværet ud eller den lineart (linjerne i tegning ofte tegnet op med en form for blæk pen) du har brugt timer på delvist forsvinder eller bliver ødelagt når du visker skitsen under ud? Vi synes det er ærgerligt at gå på kompromi så vi har kigget på et udvalg af viskelædere og sammenlignet dem for at hjælpe dig med at vælge lige den der passer til dit behov. </p><p> Den første er det klassiske Staedler mars plastic viskelæder. Som det kan ses på billedeter det godt til blyant tager lidt blæk med og ødelægger lidt farveblyanten. </p><p> Det næste er et billigt GRENE viskelæder. Denne klare sig ikke helt lige så godt som Steadler Mars. </p><p> Den sidste er Faber - Castell ‘Dust - free’. Dette er ikke helt støvfri men producerer en del mindre støv end de andre viskelædere.</p><p>Alt i alt Er Faber - Catell godt hvis man er træt af støv, GRENE godt hvis man bare vil have en billigt løsning og Steadler godt hvis man ikke har noget imod at skulle fjerne støvet.Du kan selv prøve dem af hvis du vil se det med dine egne øjne.</p>", new DateTime(2020, 5, 20, 10, 38, 6, 100, DateTimeKind.Local).AddTicks(4929), "Bedste viskelæder til dit behov" },
                    { 2, "<p>Der findes mange forskellige mærker af markers og det kan være svært at vide hvad der er bedst. Så her sammenligner vi 3 mærker af markers og giver vores anbefalinger til dig om hvad de er gode til.</p><p>Den første er Design Twin Markers.En af de billigere muligheder derude.De har et godt udvalg af farver.De har en spids i hver ende.En bullet tip i den ene til mere præcis.En chisel tip i den anden ende til større områder.Kvaliteten er god.</ p >< p >Den næste vi har kigget på er er Touch Twin Markers.Har et godt farveudvalg.Ligesom Design Twin Markers har de to spiser.Den ene værende den brede chisel tip og den anden værende en Brush tip.Brush tip er mere fleksible og giver større variation i de linjer man kan lave med dem.De gør det nemt at lave fine detaljer og farvelægge lidt større områder nemt og hurtigt.De har god blæk der en god enshed.</ p >< p >Sidst kiggede vi på Copic.Et af de mest kendte mærker, men også en af de dyreste.Det er et mærke ofte brugt af professionelle.Copic fås i forskellige slags Original, Sketch og Ciao.Vi har valgt at fokusere på Ciao den billigste version som er god hvis man har lyst at prøve copic uden at skal tømme lommerne helt.De har dog også mindre blæk i sig.Copic Ciao har også chisel og brush tips.God kvalitet blæk med jævn fordeling.</ p >< p > Design Twin Markers er gode som er billigere mulighed hvis ikke Brush tip er noget man er interesseret i.Touch Twin Markers er lidt dyrerer, men en godt bud hvis du gerne vil prøve at arbejde med brush markers uden at skulle investerer helt vildt stort.Sidst Copic Ciao godt til at prøve Copic og begynde i det mere professionelle, men hvis du allerede ved du vil komme til at bruge dem meget  kan den hurtigt blive en fordel at vælge Sketch versionen da disse kan genopfyldes.</ p >< p > Nu kan de vælge bedre efter behov eller teste dem alle og se hvad der passer dig bedst.</p>", new DateTime(2020, 5, 20, 10, 38, 6, 100, DateTimeKind.Local).AddTicks(5443), "Hvilken marker er bedst til dig" },
                    { 3, "<p>Man må omfavne rod og kaos, når man arbejder med soft pastel. Kunstner Marlene Rye har vist os har hvad man kan opnå med de støvende farver.Med brug af soft pastel, pastelblyanter og pastel venlige Canson Mi - Teintes Touch Papir har hun skabt et smukt landskab. </p><p>Tegn med pastel på papiret de store figure og farve felter fra dit motiv.Gem de fine detaljer til senere.Du vil sandsynligvis kunne se noget af papiret igennem farverne.Detaljer kan være svære at opnå med soft pastel så fortvivl ikke hvis det ikke ligner helt!</p><p>Når farverne er på plads kan du bruge en finger til at blande farverne.Du kan også bruge et stykke køkkenrulle for at få mindre på fingerne.Nu skulle du have skabt en mere solid farve med mindre papir synligt.Mangler der farve nogle steder ? Tilføj mere og bland eller blend med fingre eller papir igen.</p><p>Så det tid til detaljer! Brug kanterne af soft pastel stykkerne og eller supplimenter med pastelblyanterne og tegn detaljerne ind.Blend ikke her for at behold de skarpeste detaljer. Gennemgå til du er tilfreds eller mere farve ikke vil hænge ved papiret og prøv et nyt motiv eller det samme igen og se om det er nemmere denne gang.Måske du opdager din helt egen måde og rækkefølge at bruge materialerne i.Skitse med blyanter først evt. for nemmere at fylde farverne ind eller brug udelukkende soft pastel stykker i stor bløde strøg.Der er mange måder at gøre det på.</p><p>Marlene Rye har udvalgt farverne og materialerne hun selv har brugt i billedet.Prøv dem selv af og få inspiration fra de ørken inspirerede farver og hendes fantastiske eksempel på brugen af dem.</p><h3>Om Kunstneren:</h3><p>Marlene Rye har en A.B.fra Smith College og en M.F.A.fra University of Pennsylvania.Hun har studeret under Andrew Forge, Barbara Grossman, John Moore og Martha Armstrong.Hendes arbejde er blevet vist nationalt og er blevet accepteret til bedømte shows med højtstående konservatorer fra Whitney Museum of American Art og Guggenheim.Hun har haft 20 solo - shows siden 1994.</ p >< p >Instagram: @marlenerye_art <br>Facebook: Marlene Rye Art <br>Website: <a href='www.MarleneRye.com' terget='_blank' > www.MarleneRye.com </a></p>", new DateTime(2020, 5, 20, 10, 38, 6, 100, DateTimeKind.Local).AddTicks(5465), "Prøv soft pastel" },
                    { 4, "<p>Oplev kompleksiteten af menneskets følelser med kunstneren Riso Chan når du bruger disse omhyggeligt udvalgte farve palette af Daler Rowney Aquafine Gouache.</p><p>Riso Chan demonstrarer hvordan hun bruger disse nemt og simplet.</p><p>Skitser et motiv på et stykke papir med nogen vægt.f.eks.Bockingford CP Watercolour Paper(220gsm).Mal derefter med penslen.Gouachen er vandbaseret så du kan fortynde det med vand og få endnu mere ud af farverne.</p><p>Start evt.ud med et tyndere vand for tyndt lag i de lys områder.Det første lag behøver ikke være perfekt da gouache ikke er gennemsigtig og du kan lægge et lag farve oven på.Husk dog at jo mere vand det er blandet med jo mere gennemsigtig vil det være.</p><p>Fortsæt med at bygge lagene op med mere eller mindre vand i gouachen eller måske bare helt direkte fra tuben.</p><p>Riso Chan har udarbejdet et eksempel på en et emotionelt ansigt med disse materialer.Prøv selv kræfter med dem.Male et ansigt med følelserne vist i både farver og udseende.Tag inspiration fra Riso Chans billede og udforsk følelser.Hvem vil du male og hvad føler de!</p><p><h3>Om Kunstneren:</h3><p>Riso Chan er en kunstner og kreativ lærer med base i Amsterdam.Hun voksede op i et kunstnerisk miljø, hvor hendes mor var billedhugger, der inspirerede hende til at udforske sin egen kreativitet fra en tidlig alder.Hun mener, at portrætter kan være en meget kraftig måde at udtrykke følelser og menneskelig skønhed på.Det er et sprog på egen hånd, der ikke bruger ord til at kommunikere, det er derfor, det meste af hendes arbejde drejer sig om portrætter.Riso arbejder hovedsageligt med akvarel og gouache, skønt hun også sommetider eksperimenterer med digitalt maleri.</p><p>Instagram - @risochan</p>", new DateTime(2020, 5, 20, 10, 38, 6, 100, DateTimeKind.Local).AddTicks(5469), "Ny med gouache" },
                    { 5, "<p>I disse indelukkede dage kan det være svært at få tiden til at gå. Men hvorfor ikke bruge tiden med de små i hjemmet og lav noget nyt pynt til væggene? I disse indelukkede dage kan det være svært at få tiden til at gå. Men hvorfor ikke bruge tiden med de små i hjemmet og lav noget nyt pynt til væggene?</p><p>Med Pouring-Fluid og hobbymaling kan man lave flotte abstrakte værker med marmoreringseffekt.Prøv det selv med disse trin.</p><p>TRIN 1. Læg alle materialerne frem: Lærred, maling, Pouring-Fluid, plastkrus, rørepinde/ispinde, gummihandsker, underlag og noget, der hæver lærredet op fra underlaget.</p><p>Hver opmærksom på at 150 ml Pouring-Fluid er lige akkurat nok til et lærred på 30 x 30 cm.</p><p>TRIN 2. Hæld lidt af hver farve maling du vil bruge op i hvert sit krus. Hæld Pouring-Fluid oveni. Blandingen skal være så flydende, at den løber.</p><p>TRIN 3. Rør så malingen og Pouring-Fluid bliver godt blandet.</p><p>TRIN 4.Tag et nyt krus og hæld den hvide blanding i først. Hæld derefter en anden farve ned i midten. Efterfølgende hælder du en tredje farve ned i midten.TRIN 5.Stik forsigtigt rørepinden ned midt i og træk farven ud i siden.</p><p>TRIN 6.Læg lærredet ovenpå kruset og vend det hele, så lærredet ender nederst.</p><p>TRIN 7.Løft kruset så al malingen løber ud.</p><p>TRIN 8. Løft lærredet og vip det til siderne, så malingen løber.</p><p>TRIN 9.Hæld flere farveblandinger i kruset, gerne flere forskellige farver, og fortsæt til lærredet er dækket. Lad det også løbe ned ad siderne.</p><p>TRIN 10.Mal linjer på maleriet ved at hælde en ren farveblanding på.</p><p>TRIN 11.Bland evt. en fjerde farve med (her er brugt blå).</p><p>TRIN 12.Løft lærredet igen og lad farverne løbe til du er tilfreds. Vær opmærksom på at farverne løber lidt videre af sig selv, når du lægger lærredet ned igen. Lad værket tørre i mindst 24 timer</p><p>Nu har i laver et flot værk der kan hænges på vægge og give nyt liv i rummet. </p>", new DateTime(2020, 5, 20, 10, 38, 6, 100, DateTimeKind.Local).AddTicks(5472), "Mal med de små" },
                    { 6, "<p>Klip flotte gækkebreve med detaljerede mønstre af påskekyllinger og påskeliljer. Du kan klippe ud fra gækkebrev skabelonerne, du finder her på siden eller lave dine egne flotte designs.</p><p><h3>Step 1.</h3><p>Find evt.gækkebrev skabelonerne, og klip omridset af skabelonen ud.</p><h3>Step 2.</h3><p>Fold et A4 papir efter anvisningen på kabelonarket.Vær opmærksom på at hjørnerne mødes, så gækkebrevet kan foldes ud.Sæt skabelonen fast med clips og klip med en god, spids saks.</p><h3>Step 3.</h3><p>Line op med kanterne og lim fast til karton. Flere version som du har løst. Så kan du sende det til bedsteforældrene eller vennerne og håbe de ikke kan gætte det.</p> ", new DateTime(2020, 5, 20, 10, 38, 6, 100, DateTimeKind.Local).AddTicks(5477), "Gækkebrev med påskekylling" },
                    { 7, "<p>Med Posca tusch kan du tegne på sten med hobbymaling. Tuschen er dækkende og tørrer hurtigt - derfor er den helt perfekt at bruge til at male på sten.</p><h3>Trin 1</h3><p>Tegn og mal fine figurer og motiver på sten med Posca tuscher.</p><h3>Trin 2</h3><p>Giv evt.stenen en gang lak for at bevarer motiverne længere.</p><p>Der er mange måde motiver og materialer at bruge Posca tusserne med.</p>", new DateTime(2020, 5, 20, 10, 38, 6, 100, DateTimeKind.Local).AddTicks(5480), "Posca på sten til nye have dekorationer" },
                    { 8, "<p>Med en bullet journal kan du skrive noter, lave lister samt bruge den som kalender. En bullet journal bruges både til at give én overblik over det, man har gang i, men også som et afstressende øjeblik i hverdagen. Kom nemt i gang med brug af øvehæftet.</p><h3>Trin 1</h3><p>Skriv og tegn de lister kalendere eller aktivitets sporinger du vil.</p><h3>Trin 2</h3><p>Tilføj farver med dine tusser(ofte vandbaserede, da alkoholbaserede for det meste går igennem sidernes papir).</p><h3>Trin 3</h3><p>Øvehæftet gør det nemt at finde inspiration og skabe stemninger i bogen.</p><p>Mangler du mere inspiration? Der er masser af folk på nettet der giver tips og tricks til hvordan de laver deres bullet journal, men de vil altid være personlige for dem der bruger dem.Prøv det selv med vores samling af begyndervenlige bullet journal materialer.</p>", new DateTime(2020, 5, 20, 10, 38, 6, 100, DateTimeKind.Local).AddTicks(5483), "Start din bullet journal Rejse" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Papir" },
                    { 2, "Maling" },
                    { 3, "Tegning" },
                    { 4, "Tilbehør" }
                });

            migrationBuilder.InsertData(
                table: "BlogPostComment",
                columns: new[] { "BlogPostCommentId", "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate", "BlogPostCommentText", "BlogPostCommentUser", "BlogPostId" },
                values: new object[] { 1, new DateTime(2020, 5, 20, 10, 38, 6, 100, DateTimeKind.Local).AddTicks(8000), new DateTime(2020, 5, 20, 10, 38, 6, 100, DateTimeKind.Local).AddTicks(7369), "what", "who", 1 });

            migrationBuilder.InsertData(
                table: "BlogPostImg",
                columns: new[] { "BlogPostImgId", "BlogPostId", "ImgAltText", "ImgFileUrl", "ImgType" },
                values: new object[,]
                {
                    { 30, 8, "Bullet journal", "~/img/BlogBilleder/bulletjournal2.jpg", "blogbillede" },
                    { 29, 8, "Bullet journal", "~/img/BlogBilleder/bulletjournal1.jpg", "Coverbillede" },
                    { 27, 7, "Posca på sten", "~/img/BlogBilleder/drawingsstone.jpg", "Coverbillede" },
                    { 26, 6, "clipart-3", "~/img/BlogBilleder/clipart-3.jpg", "blogbillede" },
                    { 25, 6, "clipart-2", "~/img/BlogBilleder/clipart-2.jpg", "Coverbillede" },
                    { 24, 6, "clipart-1", "~/img/BlogBilleder/clipart-1.jpg", "blogbillede" },
                    { 23, 5, "pourpainting trin 12", "~/img/BlogBilleder/pourpainting-12.jpg", "Coverbillede" },
                    { 22, 5, "pourpainting trin 11", "~/img/BlogBilleder/pourpainting-11.jpg", "blogbillede" },
                    { 21, 5, "pourpainting trin 10", "~/img/BlogBilleder/pourpainting-10.jpg", "blogbillede" },
                    { 20, 5, "pourpainting trin 9", "~/img/BlogBilleder/pourpainting-9.jpg", "blogbillede" },
                    { 19, 5, "pourpainting trin 8", "~/img/BlogBilleder/pourpainting-8.jpg", "blogbillede" },
                    { 18, 5, "pourpainting trin 7", "~/img/BlogBilleder/pourpainting-7.jpg", "blogbillede" },
                    { 17, 5, "pourpainting trin 6", "~/img/BlogBilleder/pourpainting-6.jpg", "blogbillede" },
                    { 16, 5, "pourpainting trin 5", "~/img/BlogBilleder/pourpainting-5.jpg", "blogbillede" },
                    { 28, 7, "Posca på sten", "~/img/BlogBilleder/monstersten_1.jpg", "blogbillede" },
                    { 14, 5, "pourpainting trin 3", "~/img/BlogBilleder/pourpainting-3.jpg", "blogbillede" },
                    { 15, 5, "pourpainting trin 4", "~/img/BlogBilleder/pourpainting-4.jpg", "blogbillede" },
                    { 1, 1, "Før viskelædere blev brugt", "~/img/BlogBilleder/viskelædertest1.jpg", "blogbillede" },
                    { 3, 1, "Efter steadler mars og Grene", "~/img/BlogBilleder/viskelædertest3.jpg", "blogbillede" },
                    { 4, 1, "Alle viskelædre brugt", "~/img/BlogBilleder/viskelædertest4.jpg", "blogbillede" },
                    { 5, 2, "Linje tykkelser og flade eksempler med de tre marker typer", "~/img/BlogBilleder/markertest.jpg", "blogbillede" },
                    { 6, 3, "Break Away Heart by Marlene Rye", "~/img/BlogBilleder/Marlene-Rye_Break-Away-Heart", "Coverbillede" },
                    { 2, 1, "Efter steadler mars", "~/img/BlogBilleder/viskelædertest2.jpg", "blogbillede" },
                    { 8, 3, "Soft pastel marterialer", "~/img/BlogBilleder/softpastelmaterials.jpg", "blogbillede" },
                    { 9, 4, "RisoChan Gouache Materialer", "~/img/BlogBilleder/RisoChan-GouacheMaterialer,jpg", "Coverbillede" },
                    { 10, 4, "Riso Chans Gouache maleri", "~/img/BlogBilleder/risochan-web.jpg", "blogbillede" },
                    { 11, 4, "Gouache marterialer", "~/img/BlogBilleder/Gouachematerials.jpg", "blogbillede" },
                    { 12, 5, "pourpainting trin 1", "~/img/BlogBilleder/pourpainting-1.jpg", "blogbillede" },
                    { 7, 3, "Fan eksemple på soft pastel brug", "~/img/BlogBilleder/krinstikeks.jpg", "blogbillede" },
                    { 13, 5, "pourpainting trin 2", "~/img/BlogBilleder/pourpainting-2.jpg", "blogbillede" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 11, 3, "Dette er en fremragende træ- og blyblyant fra Lyra. Disse blyanter bliver hurtigt et meget populært tegningsprodukt på grund af deres høje kvalitet og deres pålidelige brug. Det er et meget smart tegneinstrument med en højglans blå farve, en farvet dyppet ende og guldprægede sortering. Det giver bestemt en god tilføjelse til din blyantkollektion og den bløde kerne giver en dejlig mørk linje.", "Lyra Robinson 3B Pencil", 24.95m },
                    { 22, 3, "Stregtykkelse: 2,5 mm, PC-5M , medium, 1stk.", "Posca Tusch 2,5mm", 23.00m },
                    { 26, 3, "Sortiment af tusch, der er alkoholbaserede og lysægte - hver med rund, fin tegnespids. Stregtykkelse: 0,03mm, 0,05mm, 0,1mm, 0,2mm, 0,3mm, 0,5mm, 0,8mm, og 1,0 mm, sort, 8stk.", "Fine Line skrive/tegnetusch", 125.00m },
                    { 1, 4, "Sommetider skal der små justeringer til for at opnå det ønskede resultat, mener søstrene. GRENE har derfor kreeret dette nydelige viskelæder, der let udvisker blyantspor. Et viskelæder er vidunderligt til at korrigere detaljer, som De ikke helt blev tilfreds med. Et særdeles anvendeligt redskab til kontoret.", "GRENE viskelæder", 0.98m },
                    { 12, 4, "Van Gogh børster er lavet med yderste omhu og håndværk. Denne 191-serie (nr. 6) er en rund børste lavet med gyldent syntetisk hår af høj kvalitet. Den fine spids gør den god til kontrolleret detalje, men med lidt tryk kan der frembringes dristige tykke slag. De fleksible og stærke børster gør den modstandsdygtig over for slid, så den er en fantastisk børste til daglig brug. Det er også designet med en stor hårtæthed, så det kan rumme en stor mængde maling, hvilket gør det til det perfekte instrument til gouache-akvarelmalning.", "Royal Talens Van Gogh 191 Series Brush", 45.00m },
                    { 3, 4, "Viskelæder dust-free, fra Faber-Castell.Hvid - 63 x 22 x 12 mm.Ekstra blødt viskegummi. Til blyanter med bløde stifter.", "Farber-Castell Dust-Free viskelæder", 19.95m },
                    { 13, 4, "Dette enkle viskelæder i høj kvalitet kan fjerne de fleste blyantlinjer uden at forårsage grimme udtværinger, udtværing eller blødning. Det er lavet af et kvalitetsmateriale, der er blødt og blidt, hvilket sikrer, at der ikke er unødvendig belastning på dit papir. Det er ekstremt alsidigt og kan bruges på en række forskellige overflader, såsom papir, pap og træ. KUM viskelædet er også lavet af naturlige materialer, så det er fri for PVC, latex og ftalater.", "KUM Natural Eraser", 15.00m },
                    { 18, 4, "Ispinde lyst træ midi, L: 11,5 cm, B: 10 mm, birk, 30stk", "Ispinde", 17.00m },
                    { 8, 3, "Bruynzeel Design Pastel Pencils er designet nøjagtigt til kunstneres, designere og illustratørers behov. Disse pastelblyanter i høj kvalitet er udformet med de fineste lysfaste pigmenter og Kaolin-ler. De 3,7 mm brede målere, perfekt centrerede og dobbeltlimede farvede kerner kombineres med de fineste lette cedertræk for at gøre dem meget modstandsdygtige over for brud. De holder også et punkt bedre end de fleste pastelflyanter og er en glæde at skærpe", "Bruynzeel Design Pastel Pencil", 20.00m },
                    { 20, 4, "Hvid limstift i rigtig god kvalitet til karton, papir m.m. 21 g. Tørrer klart op.", "White limstift, 21 g, 1stk.", 23.00m },
                    { 2, 4, "Viskelæder af højeste kvalitet til alle typer af blyanter, grafitlinjer og farveblyanter.", "Steadtler Mars Plastic viskelæder", 25.00m },
                    { 7, 3, "Et sæt på 10 halve stick bløde pasteller fra Royal Talens Rembrandt professionelle sortiment. Pasteller er en blød kridtype baseret på kaolin (porcelæn) og pigment, hvormed tegninger kan laves i en stil, der ligner maleri. Kunstnere, der arbejder med pasteller, har en tendens til at se deres arbejde som et maleri snarere end en tegning. Disse pasteller tilbyder fremragende farveudgivelse og intense, rene farver. De har en god grad af lysfasthed og meget høj farvekraft på grund af den høje koncentration af pigment. Rembrandt bløde pasteller skylder deres kvalitet til det tætte samarbejde med professionelle kunstnere kombineret med traditionel ekspertise og mere end et århundredes erfaring med pastelfabrikation. Hver farve er lavet efter en unik formel, og de nødvendige råvarer gennemgår meget strenge kontroller for hver nye batch.", "Rembrandt Soft Pastel Half Stick Set", 120.00m },
                    { 23, 1, "Bullet Journal fra tyske LEUCHTTURM1917 henvender sig til dig, som synes, at der ikke er noget mere herligt end at organisere livet på en kreativ og pæn måde. Punktmønstret papir. Størrelse: A5. Indeholder en guide til Bullet Journaling", "LEUCHTTURM1917 Bullet Journal (dotted)", 180.00m },
                    { 5, 3, "Touch Twin Brush Marker er en alkoholbaseret tusch, der er tilgængelig i 204 farver. To spidser, en med penselspids(brush tip) i den ene ende og en bred spids(Chisel tip) i den anden. Spidserne kan udskiftes. Den halvtransparente tusch lægges i lag og gør det nemt at lave bløde toner og overgange. Produktet er velegnet til hobbyfolket såvel som illustratorer og designere. Vi anbefaler at supplere med en farveløs blender og markerpapir.", "Touch Twin Marker", 39.00m },
                    { 4, 3, "Design Twin markers er en smart og enkelt 2-i-1 markers til dine tegninger og illustrationer. Sættet med 12 standardfarver giver dig en god base og grundlag for dine designs. Brug sættet sammen med mange af vores andre Design Twin markers og giv liv til dine tegninger og illustrationer. Med et standardsæt af 12 farver får du farver der dækker dit basisbehov. Med en tyk og en tynd ende kan du variere dine streger og derved er der endnu flere muligheder i de 12 markers. Brug begge ender og skab flotte motiver og designs.Den tynde ende måler 1,5 mm og den tykke ende måler 7,0 mm.", "Design Twin Markers 12 stk. Standart sæt", 169.95m },
                    { 17, 2, "Vandbaseret hobbymaling i rigtig god kvalitet med høj farvepigmentering, der giver en god dækkeevne. Tørrer hurtigt op og efterlader en silkemat overflade. Velegnet til træ, pap, gips osv..", "Plus Color hobbymaling, black, 60ml", 24.95m },
                    { 16, 2, "Akryl- og vandbaseret klar medie, som blandes med akryl- eller hobbymaling for at gøre malingen mere flydende og dermed velegnet til diverse fluid painting/acrylic pouring teknikker. Kan også anvendes ufortyndet som en transparent.Tørrer blankt og vandfast op og gulner ikke.", "Pouring-Fluid 150ml", 47.00m },
                    { 10, 2, "Denne farvepakke er en ideel introduktion til Aquafine Gouache akvarelfarver. Aquafine-akvareller er lavet af et omhyggeligt udvalg af moderne højkvalitetspigmenter, der er formalet til perfektion for at give optimal ydelse og kontrol. Disse rige farver har smuk pigmentering og egenskaber, der producerer smukke, sarte vaske hver gang. Disse malinger kombinerer en moderne måde at bruge akvarel på med de traditionelle essentials, der følger med at bruge dette medium, hvilket gør dette innovative sortiment ideelt til blandede medier såvel som traditionelle teknikker.", "Daler Rowney Aquafine Gouache", 36.00m },
                    { 21, 1, "L: 11 cm, højre, 1stk.", "Silhuetsaks", 32.00m },
                    { 19, 1, "Flere farver, A4 210x297 mm, 220 g, 10stk.", "Karton A4 10stk.", 19.95m },
                    { 15, 1, "Grundmalet, ubleget bomuldslærred i superkvalitet. Opspændt på blindramme med sømfri kant, hæftet på bagsiden. str. 30x30 cm, dybde 1,6 cm,360 g", "ArtistLine Canvas 30x30cm", 35.00m },
                    { 14, 1, "Et meget populært vandfarvepapir, der er meget absorberende, med et smukt struktureret udseende. Det fremstilles traditionelt på St Cuthberts Mølle ved hjælp af en høj alfa-cellulose. Det har en attraktiv overflade, der er skabt ved hjælp af naturlige uldfilt, hvilket giver papiret en smukt tekstureret finish, der er meget stabil og med fremragende farveopløftningsevner.", "Bockingford CP Watercolour Paper 220gsm", 23.00m },
                    { 9, 1, "Canson Mi-Teintes Touch Paper er det ultimative papir til pastelkridt med en ru overflade der minder om fint sandpapir. Overfladen får kul, pastel, kridt og akryl til at fremtræde smukt på papiret, og bevarer pastelpigmenterne hvilket gør det muligt at male i flere lag.", "Canson Mi-Teintes Touch Paper", 199.95m },
                    { 24, 4, " Hand Lettering 1.000 dekorative idéer er for alle - fra nybegyndere til øvede. Bogen er fuld af overskuelige  vejledninger, så man nemt lærer de grundlæggende teknikker. Du får masser DIY's, øvelser og tips, så du selv som nybegynder kan være med. Bogen indeholder masser af inspirerende eksempler, som bl.a. kan bruges i bullet journals. Denne bog er både et opslagsværk, en inspirationskilde med masser af idéer og en guldgrube af dekorative elementer. Str. 22x23 cm, tykkelse 2 cm, dansk tekst 143 sider.", "Handlettering - 1000 dekorative ideer", 149.95m },
                    { 6, 3, "Copic Ciao er den perfekte ud af Copic's tusser til nybegyndere, elever, studerende og amatørkunstnere, og prisen er yderst rimelig. Permanent, giftfrit, syrefrit og alkoholbaseret blæk, som er hurtigtørrende. Pennen har to standardspidser, en mediumbred i den ene ende, og pensel i den anden. Hætten er farvet, så du hurtigt kan vælge farve.", "Copic Ciao", 49.00m },
                    { 25, 4, "Hand Lettering er håndtegnede og smukt dekorerede ord og statements. Skab selv unikke og personlige fødselsdagskort og indbydelser, lav fine mærkater og skilte eller sæt dit eget præg på alt fra t-shirts, tasker, porcelæn og glas til billeder og tavler. Dette øvehæfte giver dig rig mulighed for at lære, hvordan flotte bogstaver og illustrationer som kranse, blomster, bånd og krummelurer bygges op og guider dig igennem trin for trin vejledninger. Du får masser af DIY´s, idéer, tips og tricks, der motiverer dig til at tage blyanten i hånden og komme i gang. Efter lidt øvelse kan du kreere dekorative kunstværker  og glæde dig selv, familie og venner med din personlige streg.Alt, du skal bruge for at komme i gang, er blyant, viskelæder, lineal og fineliner, så er du klædt på til mange timers fordybelse.Prøv også at farvelægge eksemplerne og illustrationerne i bogen og nyd at lege med forskellige farvekombinationer.", "Hand Lettering Øvehæftet til Grundbogen", 79.95m }
                });

            migrationBuilder.InsertData(
                table: "ProductComment",
                columns: new[] { "ProductCommentId", "ProductCommentDate", "ProductCommentLastUpdated", "ProductCommentText", "ProductCommentUser", "ProductId" },
                values: new object[] { 1, new DateTime(2020, 5, 20, 10, 38, 6, 92, DateTimeKind.Local).AddTicks(904), new DateTime(2020, 5, 20, 10, 38, 6, 99, DateTimeKind.Local).AddTicks(8954), "", "", 1 });

            migrationBuilder.InsertData(
                table: "ProductImg",
                columns: new[] { "ProductImgId", "BlogPostId", "ProductId", "ProductImgAltText", "ProductImgFileUrl", "ProductImgType" },
                values: new object[,]
                {
                    { 13, 0, 9, "Canson Mi Teintes Touch", "~/img/varer/canson_mi_teintes_touch", "productImg" },
                    { 24, 0, 20, "Lim", "~/img/varer/lim.jpg", "productImg" },
                    { 22, 0, 18, "Ispinde", "~/img/varer/ispinde.jpg", "productImg" },
                    { 17, 0, 13, "KUM natural viskelæder", "~/img/varer/KUM-natural-eraser_250x.jpg", "productImg" },
                    { 16, 0, 12, "RoyalTalens-VanGogh-191-Series-No6-Brush", "~/img/varer/RoyalTalens-VanGogh-191-Series-No6-Brush_250x.jpg", "productImg" },
                    { 3, 0, 3, "faber-castell-dust-free-eraser", "~/img/varer/faber-castell-dust-free-eraser.jpg", "productImg" },
                    { 2, 0, 2, "test", "~/img/varer/steadtler-mars-plastic.jifi", "productImg" },
                    { 1, 0, 1, "GRENEviskelæder", "~/img/varer/GRENEviskelæder.jifi", "productImg" },
                    { 32, 0, 26, "fine liners", "~/img/varer/fineliner.jpg", "productImg" },
                    { 28, 0, 22, "Sten tegnet med POSCA", "~/img/varer/monstersten_1.jpg", "productImg" },
                    { 27, 0, 22, "Posca sæt 10stk", "~/img/varer/POSCAset.jpg", "productImg" },
                    { 26, 0, 22, "posca", "~/img/varer/posca2.5mm.jpg", "productImg" },
                    { 15, 0, 11, "Lyra-Robinson-3B-Pencil", "~/img/varer/Lyra-Robinson-3B-Pencil_250x.jpg", "productImg" },
                    { 12, 0, 8, "test", "~/img/varer/Bruynzeel-design-pastel-pencil.jpg", "productImg" },
                    { 30, 0, 24, "Hand Lettering 1000 exercises", "~/img/varer/Hand Lettering1000exercises.jpg", "productImg" },
                    { 11, 0, 7, "test", "~/img/varer/Rembrandt-Soft-Pastel-Half-Stick-10-Set_250x.jpg", "productImg" },
                    { 7, 0, 6, "Copic Ciao", "~/img/varer/copic_ciao_styckvis.jpg", "productImg" },
                    { 10, 0, 5, "Touch Twin Marker, 12 stk sæt", "~/img/varer/TouchTwinMarker12stk.jpg", "productImg" },
                    { 9, 0, 5, "Touch Twin Marker, enkel", "~/img/varer/touchtwinmarker_singleview.png", "productImg" },
                    { 6, 0, 4, "Design Twin Markers", "~/img/varer/DesignTwinMarker.PNG", "productImg" },
                    { 5, 0, 4, "Design Twin Markers", "~/img/varer/DesignTwinMarkerSideView.PNG", "productImg" },
                    { 4, 0, 4, "Design Twin Markers", "~/img/varer/design-twin-marker-pastel-SingleView.jpg", "productImg" },
                    { 21, 0, 17, "hobby maling sort", "~/img/varer/hobby-maling-sort.jpg", "productImg" },
                    { 20, 0, 16, "Pouring Fluid", "~/img/varer/Pouring-Fluid.jpg", "productImg" },
                    { 14, 0, 10, "Daler Rowney Gouache Opaque Watercolour Paint", "~/img/varer/Daler-Rowney-Gouache-Opaque-Watercolour-Paints.jpg", "productImg" },
                    { 29, 0, 23, "Leuchturm1917 Dotted", "~/img/varer/notebogA5.jpg", "productImg" },
                    { 25, 0, 21, "Saks", "~/img/varer/saks.jpg", "productImg" },
                    { 23, 0, 19, "Karton", "~/img/varer/karton-lysblå.jpg", "productImg" },
                    { 19, 0, 15, "30x30 cm lærred", "~/img/varer/Lærred.jpg", "productImg" },
                    { 18, 0, 14, "Bockingford Block", "~/img/varer/BockingfordBlock.jpg", "productImg" },
                    { 8, 0, 6, "Copic Ciao udvalgte farver", "~/img/varer/copic_ciao_styckvis.png", "productImg" },
                    { 31, 0, 25, "handlettering exercises paper", "~/img/varer/handletteringexercisespaper.jpg", "productImg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComment_BlogPostId",
                table: "BlogPostComment",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostImg_BlogPostId",
                table: "BlogPostImg",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComment_ProductId",
                table: "ProductComment",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImg_ProductId",
                table: "ProductImg",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostComment");

            migrationBuilder.DropTable(
                name: "BlogPostImg");

            migrationBuilder.DropTable(
                name: "ProductComment");

            migrationBuilder.DropTable(
                name: "ProductImg");

            migrationBuilder.DropTable(
                name: "BlogPost");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
