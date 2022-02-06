using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Server.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attractions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attractions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attractions_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItenaryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dateofhol = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    AttractionId = table.Column<int>(type: "int", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItenaryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItenaryItems_Attractions_AttractionId",
                        column: x => x.AttractionId,
                        principalTable: "Attractions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItenaryItems_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItenaryItems_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItenaryItems_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItenaryItems_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "8cc5917d-94d9-43fc-997f-e2839a5231b4", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "780fa910-3207-44ab-9fa2-78f4de19eeed", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6e8d1164-beca-450b-9745-11413108a5f2", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEEOflUgh3wwQRLSzr4VNHefPCFpapmFmFsAX7HaQRF2P+QY7b7YMi1nFIrBk3i9ayQ==", null, false, "50414558-8c6d-45b1-ac65-6e37264ac51e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Detail", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 2, 6, 19, 40, 38, 603, DateTimeKind.Local).AddTicks(6025), new DateTime(2022, 2, 6, 19, 40, 38, 603, DateTimeKind.Local).AddTicks(6032), "The people of India are known for their traditions of hospitality to foreigners. They have varied life styles, cultural heritage and colourful fairs and festivals. Which make India a unique tourist destination. India abounds in attractive and well-preserved historical sites, ancient monuments of architectural grandeur and not-so-ancient mosques/durgahs, churches and places of worship of other diverse faiths", "India", "System" },
                    { 2, "System", new DateTime(2022, 2, 6, 19, 40, 38, 603, DateTimeKind.Local).AddTicks(6037), new DateTime(2022, 2, 6, 19, 40, 38, 603, DateTimeKind.Local).AddTicks(6038), "It has everything that can be interesting to a foreigner: architectural monuments of one of the most ancient civilizations, national parks with different climate and nature, modern metropolises and small provincial towns which managed to preserve their original culture, amazing sand beaches and inaccessible snow-white mountain tops.", "China", "System" },
                    { 3, "System", new DateTime(2022, 2, 6, 19, 40, 38, 603, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 2, 6, 19, 40, 38, 603, DateTimeKind.Local).AddTicks(6041), "Most tourists in Brazil travel to Rio de Janeiro and other easily accessible sites that are in or around urban centres with well-established hospitality industries. Salvador and other parts of Bahia are major tourist attractions, and increasing numbers of vacationers are visiting other coastal areas of the Northeast. Eco-tourism is moderately popular in the Amazon region, while in the South the beaches of Santa Catarina draw large crowds of Argentine tourists.", "Brazil", "System" },
                    { 4, "System", new DateTime(2022, 2, 6, 19, 40, 38, 603, DateTimeKind.Local).AddTicks(6042), new DateTime(2022, 2, 6, 19, 40, 38, 603, DateTimeKind.Local).AddTicks(6043), "Egypt is the best-known tourist destination in the Middle East as it has a magnificent history, a timeless civilization of more than 5000 years with a huge variety of an endless number of antiquities, artifacts, and monuments. The Ancient Egypt Civilization has many hidden secrets which need to be revealed and that’s why, Many thousands of tourists from all over the world enjoy Egypt", "Egypt", "System" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Plan", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 350f, "System", new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(9969), new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(9975), "The Standard Package includes all of the necessary itemsAlso includes a goodie bag which has complementary vouchers, a pen, shirt and some toiletriesTo kickstart your journey with us.", "Normal Package", "Debit, Credit.", "System" },
                    { 2, 780f, "System", new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(9978), new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(9979), "The Exclusive Package includes items which will make u feel like a King or a QueenIt includes free transport for about 10 times, A 300 subsidy for your needs, goodie bad and 2 free tickets for an additional attractionHaving this plan will make your travel a time to remember", "Exclusive Package", "Debit, Credit.", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CountryId", "CreatedBy", "DateCreated", "DateUpdated", "Detail", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(5904), new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(5911), "If you are planning to visit Mumbai, trust us when we say it may look intimidating initially, but it is not. In fact it is one of the friendliest cities of India. The extreme energy and the fast paced life of the people here cannot be easily matched. The heart of Mumbai has some of the best and beautiful colonial architecture and if you venture out to the lesser known lanes, you will also come across several distinct bazaars, temples, fancy restaurants and a nightlife that is one of its kinds.", "Mumbai", "System" },
                    { 2, 2, "System", new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(5916), new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(5917), "From Peking opera troupes to world-class contemporary art, Beijing draws on a profound well of creativity, and that's despite the vagaries of censorship. To give the government its due, museums are more numerous than ever, curation is less prescriptive and innovation is at an all-time high.", "Beijing", "System" },
                    { 3, 3, "System", new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(5919), new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(5920), "With long distances and harrowing six-lane highways connected by spaghetti junctions, Brasília presents challenges for walkers; consider renting a car or ride shares.You'll find a lively city hidden behind the futuristic facade. It's not only a pilgrimage for architecture buffs but also foodies, night owls and those seeking a unique travel experience.", "Brasília", "System" },
                    { 4, 4, "System", new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(5921), new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(5922), "Cairo is one of the world's great megacities. As beautiful and as rich in historic finery as it is confounding and an assault on your senses to first-time visitors The main tourist attraction everyone is here to see are the Giza Pyramids on the city's doorstep, but the city itself is crammed with major monuments that span centuries of history. There are so many things to do in Cairo that you'll only be able to cover a sliver on one trip.", "Cairo", "System" }
                });

            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "Id", "ALocation", "CreatedBy", "DateCreated", "DateUpdated", "Description", "LocationID", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Mumbai, Maharashtra 400101, India", "System", new DateTime(2022, 2, 6, 19, 40, 38, 600, DateTimeKind.Local).AddTicks(6118), new DateTime(2022, 2, 6, 19, 40, 38, 602, DateTimeKind.Local).AddTicks(2260), "The Kanheri Caves are a group of caves and rock-cut monuments cut into a massive basalt outcrop in the forests of the Sanjay Gandhi National Park, on the former island of Salsette in the western outskirts of Mumbai, India ", 1, "Kanheri Caves", "System" },
                    { 2, "Huairou District, China, 101406", "System", new DateTime(2022, 2, 6, 19, 40, 38, 602, DateTimeKind.Local).AddTicks(3172), new DateTime(2022, 2, 6, 19, 40, 38, 602, DateTimeKind.Local).AddTicks(3177), "The Great Wall of China is a series of fortifications that were built across the historical northern borders of ancient Chinese states and Imperial China as protection against various nomadic groups from the Eurasian Steppe ", 2, "Great Wall of China", "System" },
                    { 3, "Quadra 702 Sul Bloco B, SHCS, Brasília - DF, Brazil", "System", new DateTime(2022, 2, 6, 19, 40, 38, 602, DateTimeKind.Local).AddTicks(3179), new DateTime(2022, 2, 6, 19, 40, 38, 602, DateTimeKind.Local).AddTicks(3180), "From the outside, the Dom Bosco Sanctuary looks like barely more than a mildly impressive concrete block. However, entry to this beloved monument reveals a remarkable space filled with heavenly blue light and stunning architectural feats. Take a moment to experience the unique beauty of this building and pay tribute to St. Dom Bosco.", 3, "Santuário São João Bosco", "System" },
                    { 4, "Al Haram, Nazlet El-Semman, Al Giza Desert, Giza Governorate, Egypt", "System", new DateTime(2022, 2, 6, 19, 40, 38, 602, DateTimeKind.Local).AddTicks(3181), new DateTime(2022, 2, 6, 19, 40, 38, 602, DateTimeKind.Local).AddTicks(3182), "The Great Pyramid of Giza is the oldest and largest of the pyramids in the Giza pyramid complexbordering present-day Giza in Greater Cairo, Egypt. It is the oldest of the Seven Wonders of the Ancient World,", 4, "The Great Pyramid of Giza", "System" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "HLocation", "LocationID", "Name", "Rating", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "+91 22 6668 1234", "System", new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(1522), new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(1529), "Band Stand, BJ Road, Mount Mary, Bandra West, Mumbai, Maharashtra 400050, India", 1, "Taj Lands End", 4.5999999999999996, "System" },
                    { 2, "+86 10 8511 7777", "System", new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(1533), new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(1534), "China, Beijing, Chaoyang", 2, "Fairmont Beijing Hotel", 4.4000000000000004, "System" },
                    { 3, "+55 61 3424-7000", "System", new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(1536), new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(1537), "SHTN Trecho 1 Conjunto 1B Bloco C - Asa Norte, Brasília - DF, 70800-200, Brazil", 3, "Royal Tulip Brasília Alvorada", 4.7000000000000002, "System" },
                    { 4, "+20 2 25777444", "System", new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(1539), new DateTime(2022, 2, 6, 19, 40, 38, 604, DateTimeKind.Local).AddTicks(1540), "1115 Nile Corniche, Sharkas, Bulaq, Cairo Governorate, Egypt", 4, "Ramses Hilton", 4.2000000000000002, "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attractions_LocationID",
                table: "Attractions",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_LocationID",
                table: "Hotels",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_AttractionId",
                table: "ItenaryItems",
                column: "AttractionId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_CountryId",
                table: "ItenaryItems",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_HotelId",
                table: "ItenaryItems",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_LocationId",
                table: "ItenaryItems",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_PaymentId",
                table: "ItenaryItems",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CountryId",
                table: "Locations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "ItenaryItems");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Attractions");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
