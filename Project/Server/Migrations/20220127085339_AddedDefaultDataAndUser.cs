using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Server.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "f2f2fbed-dd7c-4d4d-be05-0252276f9c39", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "51628622-e7aa-418f-97d3-80725044555f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c28e83c9-9b72-4a77-85d8-0554dfb2d320", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEPv4tP3CQGxVUQ0OVIP6sA+hRa8ycKD3WWGafyRJzQvzXrgrNOc8fBI46gnBovB3Pw==", null, false, "5f324b3f-c52d-4042-b8e8-07230672e6a0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "Id", "ALocation", "CreatedBy", "DateCreated", "DateUpdated", "Description", "LocationId", "Name", "Price", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Mumbai, Maharashtra 400101, India", "System", new DateTime(2022, 1, 27, 16, 53, 38, 510, DateTimeKind.Local).AddTicks(7827), new DateTime(2022, 1, 27, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(6390), "The Kanheri Caves are a group of caves and rock-cut monuments cut into a massive basalt outcrop in the forests of the Sanjay Gandhi National Park, on the former island of Salsette in the western outskirts of Mumbai, India ", null, "Kanheri Caves", 3.59f, "System" },
                    { 2, "Huairou District, China, 101406", "System", new DateTime(2022, 1, 27, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 1, 27, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7228), "The Great Wall of China is a series of fortifications that were built across the historical northern borders of ancient Chinese states and Imperial China as protection against various nomadic groups from the Eurasian Steppe ", null, "Great Wall of China", 21.28f, "System" },
                    { 3, "Quadra 702 Sul Bloco B, SHCS, Brasília - DF, Brazil", "System", new DateTime(2022, 1, 27, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7230), new DateTime(2022, 1, 27, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7231), "From the outside, the Dom Bosco Sanctuary looks like barely more than a mildly impressive concrete block. However, entry to this beloved monument reveals a remarkable space filled with heavenly blue light and stunning architectural feats. Take a moment to experience the unique beauty of this building and pay tribute to St. Dom Bosco.", null, "Santuário São João Bosco", 0f, "System" },
                    { 4, "Al Haram, Nazlet El-Semman, Al Giza Desert, Giza Governorate, Egypt", "System", new DateTime(2022, 1, 27, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7233), new DateTime(2022, 1, 27, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7234), "The Great Pyramid of Giza is the oldest and largest of the pyramids in the Giza pyramid complexbordering present-day Giza in Greater Cairo, Egypt. It is the oldest of the Seven Wonders of the Ancient World,", null, "The Great Pyramid of Giza", 45.75f, "System" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Detail", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 4, "System", new DateTime(2022, 1, 27, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(8897), new DateTime(2022, 1, 27, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(8898), "Egypt is the best-known tourist destination in the Middle East as it has a magnificent history, a timeless civilization of more than 5000 years with a huge variety of an endless number of antiquities, artifacts, and monuments. The Ancient Egypt Civilization has many hidden secrets which need to be revealed and that’s why, Many thousands of tourists from all over the world enjoy Egypt", "Egypt", "System" },
                    { 3, "System", new DateTime(2022, 1, 27, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(8826), new DateTime(2022, 1, 27, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(8827), "Most tourists in Brazil travel to Rio de Janeiro and other easily accessible sites that are in or around urban centres with well-established hospitality industries. Salvador and other parts of Bahia are major tourist attractions, and increasing numbers of vacationers are visiting other coastal areas of the Northeast. Eco-tourism is moderately popular in the Amazon region, while in the South the beaches of Santa Catarina draw large crowds of Argentine tourists.", "Brazil", "System" },
                    { 1, "System", new DateTime(2022, 1, 27, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(8813), new DateTime(2022, 1, 27, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(8821), "The people of India are known for their traditions of hospitality to foreigners. They have varied life styles, cultural heritage and colourful fairs and festivals. Which make India a unique tourist destination. India abounds in attractive and well-preserved historical sites, ancient monuments of architectural grandeur and not-so-ancient mosques/durgahs, churches and places of worship of other diverse faiths", "India", "System" },
                    { 2, "System", new DateTime(2022, 1, 27, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(8824), new DateTime(2022, 1, 27, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(8825), "It has everything that can be interesting to a foreigner: architectural monuments of one of the most ancient civilizations, national parks with different climate and nature, modern metropolises and small provincial towns which managed to preserve their original culture, amazing sand beaches and inaccessible snow-white mountain tops.", "China", "System" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "HLocation", "LocationId", "Name", "Price", "Rating", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "+91 22 6668 1234", "System", new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5435), new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5445), "Band Stand, BJ Road, Mount Mary, Bandra West, Mumbai, Maharashtra 400050, India", null, "Taj Lands End", 151f, 4.5999999999999996, "System" },
                    { 2, "+86 10 8511 7777", "System", new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5449), new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5450), "China, Beijing, Chaoyang", null, "Fairmont Beijing Hotel", 175f, 4.4000000000000004, "System" },
                    { 3, "+55 61 3424-7000", "System", new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5452), new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5453), "SHTN Trecho 1 Conjunto 1B Bloco C - Asa Norte, Brasília - DF, 70800-200, Brazil", null, "Royal Tulip Brasília Alvorada", 159f, 4.7000000000000002, "System" },
                    { 4, "+20 2 25777444", "System", new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5454), new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5455), "1115 Nile Corniche, Sharkas, Bulaq, Cairo Governorate, Egypt", null, "Ramses Hilton", 145f, 4.2000000000000002, "System" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CountryId", "CreatedBy", "DateCreated", "DateUpdated", "Detail", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, null, "System", new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(9486), new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(9486), "With long distances and harrowing six-lane highways connected by spaghetti junctions, Brasília presents challenges for walkers; consider renting a car or ride shares.You'll find a lively city hidden behind the futuristic facade. It's not only a pilgrimage for architecture buffs but also foodies, night owls and those seeking a unique travel experience.", "Brasília", "System" },
                    { 1, null, "System", new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(9474), new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(9480), "If you are planning to visit Mumbai, trust us when we say it may look intimidating initially, but it is not. In fact it is one of the friendliest cities of India. The extreme energy and the fast paced life of the people here cannot be easily matched. The heart of Mumbai has some of the best and beautiful colonial architecture and if you venture out to the lesser known lanes, you will also come across several distinct bazaars, temples, fancy restaurants and a nightlife that is one of its kinds.", "Mumbai", "System" },
                    { 2, null, "System", new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(9483), new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(9484), "From Peking opera troupes to world-class contemporary art, Beijing draws on a profound well of creativity, and that's despite the vagaries of censorship. To give the government its due, museums are more numerous than ever, curation is less prescriptive and innovation is at an all-time high.", "Beijing", "System" },
                    { 4, null, "System", new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(9488), new DateTime(2022, 1, 27, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(9489), "Cairo is one of the world's great megacities. As beautiful and as rich in historic finery as it is confounding and an assault on your senses to first-time visitors The main tourist attraction everyone is here to see are the Giza Pyramids on the city's doorstep, but the city itself is crammed with major monuments that span centuries of history. There are so many things to do in Cairo that you'll only be able to cover a sliver on one trip.", "Cairo", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
