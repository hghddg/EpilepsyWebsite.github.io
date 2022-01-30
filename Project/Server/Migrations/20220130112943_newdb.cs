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
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment = table.Column<float>(type: "real", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
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
                name: "Itenaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itenaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    CountryId = table.Column<int>(type: "int", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Boookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    ItenaryId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Boookings_Itenaries_ItenaryId",
                        column: x => x.ItenaryId,
                        principalTable: "Itenaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Boookings_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Price = table.Column<float>(type: "real", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attractions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attractions_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Price = table.Column<float>(type: "real", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItenaryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dateofhol = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    AttractionId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ItenaryId = table.Column<int>(type: "int", nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItenaryItems_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItenaryItems_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItenaryItems_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItenaryItems_Itenaries_ItenaryId",
                        column: x => x.ItenaryId,
                        principalTable: "Itenaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItenaryItems_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "84c3f6ea-a9b7-4c64-8c27-f80464bccfdd", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "9d7c759e-f48d-4493-b964-f19386d61017", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "227be96c-0c87-4ff9-ae13-b68cf1bf120a", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAENiOWP0eWFf3fJwxDYsmnh7zVM8ksDxOWvf/y7bs6DRlcO/PW4su4Nebx+nwVi3o3A==", null, false, "b1eada81-e88f-45c7-833b-06a0e9ed5938", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "Id", "ALocation", "CreatedBy", "DateCreated", "DateUpdated", "Description", "LocationId", "Name", "Price", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Mumbai, Maharashtra 400101, India", "System", new DateTime(2022, 1, 30, 19, 29, 42, 969, DateTimeKind.Local).AddTicks(1165), new DateTime(2022, 1, 30, 19, 29, 42, 970, DateTimeKind.Local).AddTicks(1076), "The Kanheri Caves are a group of caves and rock-cut monuments cut into a massive basalt outcrop in the forests of the Sanjay Gandhi National Park, on the former island of Salsette in the western outskirts of Mumbai, India ", null, "Kanheri Caves", 3.59f, "System" },
                    { 2, "Huairou District, China, 101406", "System", new DateTime(2022, 1, 30, 19, 29, 42, 970, DateTimeKind.Local).AddTicks(1930), new DateTime(2022, 1, 30, 19, 29, 42, 970, DateTimeKind.Local).AddTicks(1935), "The Great Wall of China is a series of fortifications that were built across the historical northern borders of ancient Chinese states and Imperial China as protection against various nomadic groups from the Eurasian Steppe ", null, "Great Wall of China", 21.28f, "System" },
                    { 3, "Quadra 702 Sul Bloco B, SHCS, Brasília - DF, Brazil", "System", new DateTime(2022, 1, 30, 19, 29, 42, 970, DateTimeKind.Local).AddTicks(1937), new DateTime(2022, 1, 30, 19, 29, 42, 970, DateTimeKind.Local).AddTicks(1938), "From the outside, the Dom Bosco Sanctuary looks like barely more than a mildly impressive concrete block. However, entry to this beloved monument reveals a remarkable space filled with heavenly blue light and stunning architectural feats. Take a moment to experience the unique beauty of this building and pay tribute to St. Dom Bosco.", null, "Santuário São João Bosco", 0f, "System" },
                    { 4, "Al Haram, Nazlet El-Semman, Al Giza Desert, Giza Governorate, Egypt", "System", new DateTime(2022, 1, 30, 19, 29, 42, 970, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 1, 30, 19, 29, 42, 970, DateTimeKind.Local).AddTicks(1941), "The Great Pyramid of Giza is the oldest and largest of the pyramids in the Giza pyramid complexbordering present-day Giza in Greater Cairo, Egypt. It is the oldest of the Seven Wonders of the Ancient World,", null, "The Great Pyramid of Giza", 45.75f, "System" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Detail", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 4, "System", new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(3901), new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(3901), "Egypt is the best-known tourist destination in the Middle East as it has a magnificent history, a timeless civilization of more than 5000 years with a huge variety of an endless number of antiquities, artifacts, and monuments. The Ancient Egypt Civilization has many hidden secrets which need to be revealed and that’s why, Many thousands of tourists from all over the world enjoy Egypt", "Egypt", "System" },
                    { 3, "System", new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(3898), new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(3899), "Most tourists in Brazil travel to Rio de Janeiro and other easily accessible sites that are in or around urban centres with well-established hospitality industries. Salvador and other parts of Bahia are major tourist attractions, and increasing numbers of vacationers are visiting other coastal areas of the Northeast. Eco-tourism is moderately popular in the Amazon region, while in the South the beaches of Santa Catarina draw large crowds of Argentine tourists.", "Brazil", "System" },
                    { 1, "System", new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(3885), new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(3892), "The people of India are known for their traditions of hospitality to foreigners. They have varied life styles, cultural heritage and colourful fairs and festivals. Which make India a unique tourist destination. India abounds in attractive and well-preserved historical sites, ancient monuments of architectural grandeur and not-so-ancient mosques/durgahs, churches and places of worship of other diverse faiths", "India", "System" },
                    { 2, "System", new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(3896), new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(3897), "It has everything that can be interesting to a foreigner: architectural monuments of one of the most ancient civilizations, national parks with different climate and nature, modern metropolises and small provincial towns which managed to preserve their original culture, amazing sand beaches and inaccessible snow-white mountain tops.", "China", "System" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "HLocation", "LocationId", "Name", "Price", "Rating", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "+91 22 6668 1234", "System", new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(8863), new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(8869), "Band Stand, BJ Road, Mount Mary, Bandra West, Mumbai, Maharashtra 400050, India", null, "Taj Lands End", 151f, 4.5999999999999996, "System" },
                    { 2, "+86 10 8511 7777", "System", new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(8873), new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(8874), "China, Beijing, Chaoyang", null, "Fairmont Beijing Hotel", 175f, 4.4000000000000004, "System" },
                    { 3, "+55 61 3424-7000", "System", new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(8875), new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(8876), "SHTN Trecho 1 Conjunto 1B Bloco C - Asa Norte, Brasília - DF, 70800-200, Brazil", null, "Royal Tulip Brasília Alvorada", 159f, 4.7000000000000002, "System" },
                    { 4, "+20 2 25777444", "System", new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(8878), new DateTime(2022, 1, 30, 19, 29, 42, 971, DateTimeKind.Local).AddTicks(8879), "1115 Nile Corniche, Sharkas, Bulaq, Cairo Governorate, Egypt", null, "Ramses Hilton", 145f, 4.2000000000000002, "System" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CountryId", "CreatedBy", "DateCreated", "DateUpdated", "Detail", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, null, "System", new DateTime(2022, 1, 30, 19, 29, 42, 972, DateTimeKind.Local).AddTicks(4472), new DateTime(2022, 1, 30, 19, 29, 42, 972, DateTimeKind.Local).AddTicks(4473), "With long distances and harrowing six-lane highways connected by spaghetti junctions, Brasília presents challenges for walkers; consider renting a car or ride shares.You'll find a lively city hidden behind the futuristic facade. It's not only a pilgrimage for architecture buffs but also foodies, night owls and those seeking a unique travel experience.", "Brasília", "System" },
                    { 1, null, "System", new DateTime(2022, 1, 30, 19, 29, 42, 972, DateTimeKind.Local).AddTicks(4455), new DateTime(2022, 1, 30, 19, 29, 42, 972, DateTimeKind.Local).AddTicks(4467), "If you are planning to visit Mumbai, trust us when we say it may look intimidating initially, but it is not. In fact it is one of the friendliest cities of India. The extreme energy and the fast paced life of the people here cannot be easily matched. The heart of Mumbai has some of the best and beautiful colonial architecture and if you venture out to the lesser known lanes, you will also come across several distinct bazaars, temples, fancy restaurants and a nightlife that is one of its kinds.", "Mumbai", "System" },
                    { 2, null, "System", new DateTime(2022, 1, 30, 19, 29, 42, 972, DateTimeKind.Local).AddTicks(4470), new DateTime(2022, 1, 30, 19, 29, 42, 972, DateTimeKind.Local).AddTicks(4470), "From Peking opera troupes to world-class contemporary art, Beijing draws on a profound well of creativity, and that's despite the vagaries of censorship. To give the government its due, museums are more numerous than ever, curation is less prescriptive and innovation is at an all-time high.", "Beijing", "System" },
                    { 4, null, "System", new DateTime(2022, 1, 30, 19, 29, 42, 972, DateTimeKind.Local).AddTicks(4474), new DateTime(2022, 1, 30, 19, 29, 42, 972, DateTimeKind.Local).AddTicks(4475), "Cairo is one of the world's great megacities. As beautiful and as rich in historic finery as it is confounding and an assault on your senses to first-time visitors The main tourist attraction everyone is here to see are the Giza Pyramids on the city's doorstep, but the city itself is crammed with major monuments that span centuries of history. There are so many things to do in Cairo that you'll only be able to cover a sliver on one trip.", "Cairo", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

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
                name: "IX_Attractions_LocationId",
                table: "Attractions",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Boookings_CustomerId",
                table: "Boookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Boookings_ItenaryId",
                table: "Boookings",
                column: "ItenaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Boookings_PaymentId",
                table: "Boookings",
                column: "PaymentId");

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
                name: "IX_Hotels_LocationId",
                table: "Hotels",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_AttractionId",
                table: "ItenaryItems",
                column: "AttractionId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_CountryId",
                table: "ItenaryItems",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_CustomerId",
                table: "ItenaryItems",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_HotelId",
                table: "ItenaryItems",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_ItenaryId",
                table: "ItenaryItems",
                column: "ItenaryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_LocationId",
                table: "ItenaryItems",
                column: "LocationId");

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
                name: "Boookings");

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
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Attractions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Itenaries");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
