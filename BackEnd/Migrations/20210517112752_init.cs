using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShowTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowNumber = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    ShowTimeId = table.Column<int>(type: "int", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_ShowTimes_ShowTimeId",
                        column: x => x.ShowTimeId,
                        principalTable: "ShowTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Desire", "Tillerås", "07012345678" },
                    { 2, "Tintin", "Petersson", "07045678912" },
                    { 3, "Amanda", "Eriksson", "0707894562" },
                    { 4, "Jonathan", "Kullman", "0701245789" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 9, "A journalist must investigate a mysterious videotape which seems to cause the death of anyone one week to the day after they view it.", "The Ring" },
                    { 8, "An American nurse living and working in Tokyo is exposed to a mysterious supernatural curse, one that locks a person in a powerful rage before claiming their life and spreading to another victim.", "The Grudge" },
                    { 7, "When a 12-year-old girl is possessed by a mysterious entity, her mother seeks the help of two priests to save her.", "The Exorcist" },
                    { 6, "A year after the murder of her mother, a teenage girl is terrorized by a new killer, who targets the girl and her friends by using horror films as part of a deadly game.", "Scream" },
                    { 10, "A family in 1630s New England is torn apart by the forces of witchcraft, black magic, and possession.", "The Witch" },
                    { 4, "A family's home is haunted by a host of demonic ghosts.", "Poltergeist" },
                    { 3, "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.", "IT" },
                    { 2, "Laurie Strode confronts her long-time foe Michael Myers, the masked figure who has haunted her since she narrowly escaped his killing spree on Halloween night four decades ago.", "Halloween" },
                    { 1, "After her last encounter, Ellen Ripley crash-lands on Fiorina 161, a maximum security prison. When a series of strange and deadly events occur shortly after her arrival, Ripley realizes that she has brought along an unwelcome visitor", "Alien" },
                    { 5, "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.", "Saw" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "RoomNumber" },
                values: new object[,]
                {
                    { 10, 10 },
                    { 9, 9 },
                    { 8, 8 },
                    { 7, 7 },
                    { 6, 6 },
                    { 5, 5 },
                    { 3, 3 },
                    { 2, 2 },
                    { 1, 1 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "Id", "ShowNumber", "Time" },
                values: new object[,]
                {
                    { 3, 3, "24.00" },
                    { 1, 1, "20.00" },
                    { 2, 2, "22.00" },
                    { 4, 4, "02.00" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CustomerId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 528, null, 7, 8, 3 },
                    { 529, null, 7, 9, 3 },
                    { 530, null, 7, 10, 3 },
                    { 531, null, 7, 11, 3 },
                    { 532, null, 7, 12, 3 },
                    { 533, null, 7, 13, 3 },
                    { 534, null, 7, 14, 3 },
                    { 535, null, 7, 15, 3 },
                    { 536, null, 7, 16, 3 },
                    { 537, null, 7, 17, 3 },
                    { 539, null, 7, 19, 3 },
                    { 527, null, 7, 7, 3 },
                    { 540, null, 7, 20, 3 },
                    { 601, null, 8, 1, 3 },
                    { 602, null, 8, 2, 3 },
                    { 603, null, 8, 3, 3 },
                    { 604, null, 8, 4, 3 },
                    { 605, null, 8, 5, 3 },
                    { 606, null, 8, 6, 3 },
                    { 607, null, 8, 7, 3 },
                    { 608, null, 8, 8, 3 },
                    { 538, null, 7, 18, 3 },
                    { 526, null, 7, 6, 3 },
                    { 524, null, 7, 4, 3 },
                    { 609, null, 8, 9, 3 },
                    { 443, null, 6, 3, 3 },
                    { 444, null, 6, 4, 3 },
                    { 445, null, 6, 5, 3 },
                    { 446, null, 6, 6, 3 },
                    { 447, null, 6, 7, 3 },
                    { 448, null, 6, 8, 3 },
                    { 449, null, 6, 9, 3 },
                    { 450, null, 6, 10, 3 },
                    { 451, null, 6, 11, 3 },
                    { 452, null, 6, 12, 3 },
                    { 453, null, 6, 13, 3 },
                    { 454, null, 6, 14, 3 },
                    { 455, null, 6, 15, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 456, null, 6, 16, 3 },
                    { 457, null, 6, 17, 3 },
                    { 458, null, 6, 18, 3 },
                    { 459, null, 6, 19, 3 },
                    { 460, null, 6, 20, 3 },
                    { 521, null, 7, 1, 3 },
                    { 522, null, 7, 2, 3 },
                    { 523, null, 7, 3, 3 },
                    { 525, null, 7, 5, 3 },
                    { 610, null, 8, 10, 3 },
                    { 612, null, 8, 12, 3 },
                    { 442, null, 6, 2, 3 },
                    { 698, null, 9, 18, 3 },
                    { 699, null, 9, 19, 3 },
                    { 700, null, 9, 20, 3 },
                    { 761, null, 10, 1, 3 },
                    { 762, null, 10, 2, 3 },
                    { 763, null, 10, 3, 3 },
                    { 764, null, 10, 4, 3 },
                    { 765, null, 10, 5, 3 },
                    { 766, null, 10, 6, 3 },
                    { 767, null, 10, 7, 3 },
                    { 768, null, 10, 8, 3 },
                    { 769, null, 10, 9, 3 },
                    { 770, null, 10, 10, 3 },
                    { 771, null, 10, 11, 3 },
                    { 772, null, 10, 12, 3 },
                    { 773, null, 10, 13, 3 },
                    { 774, null, 10, 14, 3 },
                    { 775, null, 10, 15, 3 },
                    { 776, null, 10, 16, 3 },
                    { 777, null, 10, 17, 3 },
                    { 778, null, 10, 18, 3 },
                    { 697, null, 9, 17, 3 },
                    { 611, null, 8, 11, 3 },
                    { 696, null, 9, 16, 3 },
                    { 694, null, 9, 14, 3 },
                    { 613, null, 8, 13, 3 },
                    { 614, null, 8, 14, 3 },
                    { 615, null, 8, 15, 3 },
                    { 616, null, 8, 16, 3 },
                    { 617, null, 8, 17, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 618, null, 8, 18, 3 },
                    { 619, null, 8, 19, 3 },
                    { 620, null, 8, 20, 3 },
                    { 681, null, 9, 1, 3 },
                    { 682, null, 9, 2, 3 },
                    { 683, null, 9, 3, 3 },
                    { 684, null, 9, 4, 3 },
                    { 685, null, 9, 5, 3 },
                    { 686, null, 9, 6, 3 },
                    { 687, null, 9, 7, 3 },
                    { 688, null, 9, 8, 3 },
                    { 689, null, 9, 9, 3 },
                    { 690, null, 9, 10, 3 },
                    { 691, null, 9, 11, 3 },
                    { 692, null, 9, 12, 3 },
                    { 693, null, 9, 13, 3 },
                    { 695, null, 9, 15, 3 },
                    { 441, null, 6, 1, 3 },
                    { 379, null, 5, 19, 3 },
                    { 779, null, 10, 19, 3 },
                    { 128, null, 2, 8, 3 },
                    { 129, null, 2, 9, 3 },
                    { 130, null, 2, 10, 3 },
                    { 131, null, 2, 11, 3 },
                    { 132, null, 2, 12, 3 },
                    { 133, null, 2, 13, 3 },
                    { 134, null, 2, 14, 3 },
                    { 135, null, 2, 15, 3 },
                    { 136, null, 2, 16, 3 },
                    { 137, null, 2, 17, 3 },
                    { 138, null, 2, 18, 3 },
                    { 139, null, 2, 19, 3 },
                    { 140, null, 2, 20, 3 },
                    { 201, null, 3, 1, 3 },
                    { 202, null, 3, 2, 3 },
                    { 203, null, 3, 3, 3 },
                    { 204, null, 3, 4, 3 },
                    { 205, null, 3, 5, 3 },
                    { 206, null, 3, 6, 3 },
                    { 207, null, 3, 7, 3 },
                    { 208, null, 3, 8, 3 },
                    { 127, null, 2, 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 209, null, 3, 9, 3 },
                    { 126, null, 2, 6, 3 },
                    { 124, null, 2, 4, 3 },
                    { 43, null, 1, 3, 3 },
                    { 44, null, 1, 4, 3 },
                    { 45, null, 1, 5, 3 },
                    { 46, null, 1, 6, 3 },
                    { 47, null, 1, 7, 3 },
                    { 48, null, 1, 8, 3 },
                    { 49, null, 1, 9, 3 },
                    { 50, null, 1, 10, 3 },
                    { 51, null, 1, 11, 3 },
                    { 52, null, 1, 12, 3 },
                    { 53, null, 1, 13, 3 },
                    { 54, null, 1, 14, 3 },
                    { 55, null, 1, 15, 3 },
                    { 56, null, 1, 16, 3 },
                    { 57, null, 1, 17, 3 },
                    { 58, null, 1, 18, 3 },
                    { 59, null, 1, 19, 3 },
                    { 60, null, 1, 20, 3 },
                    { 121, null, 2, 1, 3 },
                    { 122, null, 2, 2, 3 },
                    { 123, null, 2, 3, 3 },
                    { 125, null, 2, 5, 3 },
                    { 380, null, 5, 20, 3 },
                    { 210, null, 3, 10, 3 },
                    { 212, null, 3, 12, 3 },
                    { 298, null, 4, 18, 3 },
                    { 299, null, 4, 19, 3 },
                    { 300, null, 4, 20, 3 },
                    { 361, null, 5, 1, 3 },
                    { 362, null, 5, 2, 3 },
                    { 363, null, 5, 3, 3 },
                    { 364, null, 5, 4, 3 },
                    { 365, null, 5, 5, 3 },
                    { 366, null, 5, 6, 3 },
                    { 367, null, 5, 7, 3 },
                    { 368, null, 5, 8, 3 },
                    { 369, null, 5, 9, 3 },
                    { 370, null, 5, 10, 3 },
                    { 371, null, 5, 11, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 372, null, 5, 12, 3 },
                    { 373, null, 5, 13, 3 },
                    { 374, null, 5, 14, 3 },
                    { 375, null, 5, 15, 3 },
                    { 376, null, 5, 16, 3 },
                    { 377, null, 5, 17, 3 },
                    { 378, null, 5, 18, 3 },
                    { 297, null, 4, 17, 3 },
                    { 211, null, 3, 11, 3 },
                    { 296, null, 4, 16, 3 },
                    { 294, null, 4, 14, 3 },
                    { 213, null, 3, 13, 3 },
                    { 214, null, 3, 14, 3 },
                    { 215, null, 3, 15, 3 },
                    { 216, null, 3, 16, 3 },
                    { 217, null, 3, 17, 3 },
                    { 218, null, 3, 18, 3 },
                    { 219, null, 3, 19, 3 },
                    { 220, null, 3, 20, 3 },
                    { 281, null, 4, 1, 3 },
                    { 282, null, 4, 2, 3 },
                    { 283, null, 4, 3, 3 },
                    { 284, null, 4, 4, 3 },
                    { 285, null, 4, 5, 3 },
                    { 286, null, 4, 6, 3 },
                    { 287, null, 4, 7, 3 },
                    { 288, null, 4, 8, 3 },
                    { 289, null, 4, 9, 3 },
                    { 290, null, 4, 10, 3 },
                    { 291, null, 4, 11, 3 },
                    { 292, null, 4, 12, 3 },
                    { 293, null, 4, 13, 3 },
                    { 295, null, 4, 15, 3 },
                    { 780, null, 10, 20, 3 },
                    { 62, null, 1, 2, 4 },
                    { 42, null, 1, 2, 3 },
                    { 548, null, 7, 8, 4 },
                    { 549, null, 7, 9, 4 },
                    { 550, null, 7, 10, 4 },
                    { 551, null, 7, 11, 4 },
                    { 552, null, 7, 12, 4 },
                    { 553, null, 7, 13, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 554, null, 7, 14, 4 },
                    { 555, null, 7, 15, 4 },
                    { 556, null, 7, 16, 4 },
                    { 557, null, 7, 17, 4 },
                    { 558, null, 7, 18, 4 },
                    { 559, null, 7, 19, 4 },
                    { 560, null, 7, 20, 4 },
                    { 621, null, 8, 1, 4 },
                    { 622, null, 8, 2, 4 },
                    { 623, null, 8, 3, 4 },
                    { 624, null, 8, 4, 4 },
                    { 625, null, 8, 5, 4 },
                    { 626, null, 8, 6, 4 },
                    { 627, null, 8, 7, 4 },
                    { 628, null, 8, 8, 4 },
                    { 547, null, 7, 7, 4 },
                    { 629, null, 8, 9, 4 },
                    { 546, null, 7, 6, 4 },
                    { 544, null, 7, 4, 4 },
                    { 463, null, 6, 3, 4 },
                    { 464, null, 6, 4, 4 },
                    { 465, null, 6, 5, 4 },
                    { 466, null, 6, 6, 4 },
                    { 467, null, 6, 7, 4 },
                    { 468, null, 6, 8, 4 },
                    { 469, null, 6, 9, 4 },
                    { 470, null, 6, 10, 4 },
                    { 471, null, 6, 11, 4 },
                    { 472, null, 6, 12, 4 },
                    { 473, null, 6, 13, 4 },
                    { 474, null, 6, 14, 4 },
                    { 475, null, 6, 15, 4 },
                    { 476, null, 6, 16, 4 },
                    { 477, null, 6, 17, 4 },
                    { 478, null, 6, 18, 4 },
                    { 479, null, 6, 19, 4 },
                    { 480, null, 6, 20, 4 },
                    { 541, null, 7, 1, 4 },
                    { 542, null, 7, 2, 4 },
                    { 543, null, 7, 3, 4 },
                    { 545, null, 7, 5, 4 },
                    { 462, null, 6, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 630, null, 8, 10, 4 },
                    { 632, null, 8, 12, 4 },
                    { 718, null, 9, 18, 4 },
                    { 719, null, 9, 19, 4 },
                    { 720, null, 9, 20, 4 },
                    { 781, null, 10, 1, 4 },
                    { 782, null, 10, 2, 4 },
                    { 783, null, 10, 3, 4 },
                    { 784, null, 10, 4, 4 },
                    { 785, null, 10, 5, 4 },
                    { 786, null, 10, 6, 4 },
                    { 787, null, 10, 7, 4 },
                    { 788, null, 10, 8, 4 },
                    { 789, null, 10, 9, 4 },
                    { 790, null, 10, 10, 4 },
                    { 791, null, 10, 11, 4 },
                    { 792, null, 10, 12, 4 },
                    { 793, null, 10, 13, 4 },
                    { 794, null, 10, 14, 4 },
                    { 795, null, 10, 15, 4 },
                    { 796, null, 10, 16, 4 },
                    { 797, null, 10, 17, 4 },
                    { 798, null, 10, 18, 4 },
                    { 717, null, 9, 17, 4 },
                    { 631, null, 8, 11, 4 },
                    { 716, null, 9, 16, 4 },
                    { 714, null, 9, 14, 4 },
                    { 633, null, 8, 13, 4 },
                    { 634, null, 8, 14, 4 },
                    { 635, null, 8, 15, 4 },
                    { 636, null, 8, 16, 4 },
                    { 637, null, 8, 17, 4 },
                    { 638, null, 8, 18, 4 },
                    { 639, null, 8, 19, 4 },
                    { 640, null, 8, 20, 4 },
                    { 701, null, 9, 1, 4 },
                    { 702, null, 9, 2, 4 },
                    { 703, null, 9, 3, 4 },
                    { 704, null, 9, 4, 4 },
                    { 705, null, 9, 5, 4 },
                    { 706, null, 9, 6, 4 },
                    { 707, null, 9, 7, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 708, null, 9, 8, 4 },
                    { 709, null, 9, 9, 4 },
                    { 710, null, 9, 10, 4 },
                    { 711, null, 9, 11, 4 },
                    { 712, null, 9, 12, 4 },
                    { 713, null, 9, 13, 4 },
                    { 715, null, 9, 15, 4 },
                    { 61, null, 1, 1, 4 },
                    { 461, null, 6, 1, 4 },
                    { 399, null, 5, 19, 4 },
                    { 148, null, 2, 8, 4 },
                    { 149, null, 2, 9, 4 },
                    { 150, null, 2, 10, 4 },
                    { 151, null, 2, 11, 4 },
                    { 152, null, 2, 12, 4 },
                    { 153, null, 2, 13, 4 },
                    { 154, null, 2, 14, 4 },
                    { 155, null, 2, 15, 4 },
                    { 156, null, 2, 16, 4 },
                    { 157, null, 2, 17, 4 },
                    { 158, null, 2, 18, 4 },
                    { 159, null, 2, 19, 4 },
                    { 160, null, 2, 20, 4 },
                    { 221, null, 3, 1, 4 },
                    { 222, null, 3, 2, 4 },
                    { 223, null, 3, 3, 4 },
                    { 224, null, 3, 4, 4 },
                    { 225, null, 3, 5, 4 },
                    { 226, null, 3, 6, 4 },
                    { 227, null, 3, 7, 4 },
                    { 228, null, 3, 8, 4 },
                    { 147, null, 2, 7, 4 },
                    { 229, null, 3, 9, 4 },
                    { 146, null, 2, 6, 4 },
                    { 144, null, 2, 4, 4 },
                    { 63, null, 1, 3, 4 },
                    { 64, null, 1, 4, 4 },
                    { 65, null, 1, 5, 4 },
                    { 66, null, 1, 6, 4 },
                    { 67, null, 1, 7, 4 },
                    { 68, null, 1, 8, 4 },
                    { 69, null, 1, 9, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 70, null, 1, 10, 4 },
                    { 71, null, 1, 11, 4 },
                    { 72, null, 1, 12, 4 },
                    { 73, null, 1, 13, 4 },
                    { 74, null, 1, 14, 4 },
                    { 75, null, 1, 15, 4 },
                    { 76, null, 1, 16, 4 },
                    { 77, null, 1, 17, 4 },
                    { 78, null, 1, 18, 4 },
                    { 79, null, 1, 19, 4 },
                    { 80, null, 1, 20, 4 },
                    { 141, null, 2, 1, 4 },
                    { 142, null, 2, 2, 4 },
                    { 143, null, 2, 3, 4 },
                    { 145, null, 2, 5, 4 },
                    { 400, null, 5, 20, 4 },
                    { 230, null, 3, 10, 4 },
                    { 232, null, 3, 12, 4 },
                    { 318, null, 4, 18, 4 },
                    { 319, null, 4, 19, 4 },
                    { 320, null, 4, 20, 4 },
                    { 381, null, 5, 1, 4 },
                    { 382, null, 5, 2, 4 },
                    { 383, null, 5, 3, 4 },
                    { 384, null, 5, 4, 4 },
                    { 385, null, 5, 5, 4 },
                    { 386, null, 5, 6, 4 },
                    { 387, null, 5, 7, 4 },
                    { 388, null, 5, 8, 4 },
                    { 389, null, 5, 9, 4 },
                    { 390, null, 5, 10, 4 },
                    { 391, null, 5, 11, 4 },
                    { 392, null, 5, 12, 4 },
                    { 393, null, 5, 13, 4 },
                    { 394, null, 5, 14, 4 },
                    { 395, null, 5, 15, 4 },
                    { 396, null, 5, 16, 4 },
                    { 397, null, 5, 17, 4 },
                    { 398, null, 5, 18, 4 },
                    { 317, null, 4, 17, 4 },
                    { 231, null, 3, 11, 4 },
                    { 316, null, 4, 16, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 314, null, 4, 14, 4 },
                    { 233, null, 3, 13, 4 },
                    { 234, null, 3, 14, 4 },
                    { 235, null, 3, 15, 4 },
                    { 236, null, 3, 16, 4 },
                    { 237, null, 3, 17, 4 },
                    { 238, null, 3, 18, 4 },
                    { 239, null, 3, 19, 4 },
                    { 240, null, 3, 20, 4 },
                    { 301, null, 4, 1, 4 },
                    { 302, null, 4, 2, 4 },
                    { 303, null, 4, 3, 4 },
                    { 304, null, 4, 4, 4 },
                    { 305, null, 4, 5, 4 },
                    { 306, null, 4, 6, 4 },
                    { 307, null, 4, 7, 4 },
                    { 308, null, 4, 8, 4 },
                    { 309, null, 4, 9, 4 },
                    { 310, null, 4, 10, 4 },
                    { 311, null, 4, 11, 4 },
                    { 312, null, 4, 12, 4 },
                    { 313, null, 4, 13, 4 },
                    { 315, null, 4, 15, 4 },
                    { 41, null, 1, 1, 3 },
                    { 759, null, 10, 19, 2 },
                    { 799, null, 10, 19, 4 },
                    { 487, null, 7, 7, 1 },
                    { 488, null, 7, 8, 1 },
                    { 489, null, 7, 9, 1 },
                    { 490, null, 7, 10, 1 },
                    { 491, null, 7, 11, 1 },
                    { 492, null, 7, 12, 1 },
                    { 493, null, 7, 13, 1 },
                    { 494, null, 7, 14, 1 },
                    { 495, null, 7, 15, 1 },
                    { 496, null, 7, 16, 1 },
                    { 497, null, 7, 17, 1 },
                    { 498, null, 7, 18, 1 },
                    { 499, null, 7, 19, 1 },
                    { 500, null, 7, 20, 1 },
                    { 561, null, 8, 1, 1 },
                    { 562, null, 8, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 563, null, 8, 3, 1 },
                    { 564, null, 8, 4, 1 },
                    { 565, null, 8, 5, 1 },
                    { 566, null, 8, 6, 1 },
                    { 567, null, 8, 7, 1 },
                    { 486, null, 7, 6, 1 },
                    { 568, null, 8, 8, 1 },
                    { 485, null, 7, 5, 1 },
                    { 483, null, 7, 3, 1 },
                    { 402, null, 6, 2, 1 },
                    { 403, null, 6, 3, 1 },
                    { 404, null, 6, 4, 1 },
                    { 405, null, 6, 5, 1 },
                    { 406, null, 6, 6, 1 },
                    { 407, null, 6, 7, 1 },
                    { 408, null, 6, 8, 1 },
                    { 409, null, 6, 9, 1 },
                    { 410, null, 6, 10, 1 },
                    { 411, null, 6, 11, 1 },
                    { 412, null, 6, 12, 1 },
                    { 413, null, 6, 13, 1 },
                    { 414, null, 6, 14, 1 },
                    { 415, null, 6, 15, 1 },
                    { 416, null, 6, 16, 1 },
                    { 417, null, 6, 17, 1 },
                    { 418, null, 6, 18, 1 },
                    { 419, null, 6, 19, 1 },
                    { 420, null, 6, 20, 1 },
                    { 481, null, 7, 1, 1 },
                    { 482, null, 7, 2, 1 },
                    { 484, null, 7, 4, 1 },
                    { 401, null, 6, 1, 1 },
                    { 569, null, 8, 9, 1 },
                    { 571, null, 8, 11, 1 },
                    { 657, null, 9, 17, 1 },
                    { 658, null, 9, 18, 1 },
                    { 659, null, 9, 19, 1 },
                    { 660, null, 9, 20, 1 },
                    { 721, null, 10, 1, 1 },
                    { 722, null, 10, 2, 1 },
                    { 723, null, 10, 3, 1 },
                    { 724, null, 10, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 725, null, 10, 5, 1 },
                    { 726, null, 10, 6, 1 },
                    { 727, null, 10, 7, 1 },
                    { 728, null, 10, 8, 1 },
                    { 729, null, 10, 9, 1 },
                    { 730, null, 10, 10, 1 },
                    { 731, null, 10, 11, 1 },
                    { 732, null, 10, 12, 1 },
                    { 733, null, 10, 13, 1 },
                    { 734, null, 10, 14, 1 },
                    { 735, null, 10, 15, 1 },
                    { 736, null, 10, 16, 1 },
                    { 737, null, 10, 17, 1 },
                    { 656, null, 9, 16, 1 },
                    { 570, null, 8, 10, 1 },
                    { 655, null, 9, 15, 1 },
                    { 653, null, 9, 13, 1 },
                    { 572, null, 8, 12, 1 },
                    { 573, null, 8, 13, 1 },
                    { 574, null, 8, 14, 1 },
                    { 575, null, 8, 15, 1 },
                    { 576, null, 8, 16, 1 },
                    { 577, null, 8, 17, 1 },
                    { 578, null, 8, 18, 1 },
                    { 579, null, 8, 19, 1 },
                    { 580, null, 8, 20, 1 },
                    { 641, null, 9, 1, 1 },
                    { 642, null, 9, 2, 1 },
                    { 643, null, 9, 3, 1 },
                    { 644, null, 9, 4, 1 },
                    { 645, null, 9, 5, 1 },
                    { 646, null, 9, 6, 1 },
                    { 647, null, 9, 7, 1 },
                    { 648, null, 9, 8, 1 },
                    { 649, null, 9, 9, 1 },
                    { 650, null, 9, 10, 1 },
                    { 651, null, 9, 11, 1 },
                    { 652, null, 9, 12, 1 },
                    { 654, null, 9, 14, 1 },
                    { 738, null, 10, 18, 1 },
                    { 340, null, 5, 20, 1 },
                    { 338, null, 5, 18, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 87, null, 2, 7, 1 },
                    { 88, null, 2, 8, 1 },
                    { 89, null, 2, 9, 1 },
                    { 90, null, 2, 10, 1 },
                    { 91, null, 2, 11, 1 },
                    { 92, null, 2, 12, 1 },
                    { 93, null, 2, 13, 1 },
                    { 94, null, 2, 14, 1 },
                    { 95, null, 2, 15, 1 },
                    { 96, null, 2, 16, 1 },
                    { 97, null, 2, 17, 1 },
                    { 98, null, 2, 18, 1 },
                    { 99, null, 2, 19, 1 },
                    { 100, null, 2, 20, 1 },
                    { 161, null, 3, 1, 1 },
                    { 162, null, 3, 2, 1 },
                    { 163, null, 3, 3, 1 },
                    { 164, null, 3, 4, 1 },
                    { 165, null, 3, 5, 1 },
                    { 166, null, 3, 6, 1 },
                    { 167, null, 3, 7, 1 },
                    { 86, null, 2, 6, 1 },
                    { 168, null, 3, 8, 1 },
                    { 85, null, 2, 5, 1 },
                    { 83, null, 2, 3, 1 },
                    { 1, null, 1, 1, 1 },
                    { 2, null, 1, 2, 1 },
                    { 3, null, 1, 3, 1 },
                    { 4, null, 1, 4, 1 },
                    { 5, null, 1, 5, 1 },
                    { 6, null, 1, 6, 1 },
                    { 7, null, 1, 7, 1 },
                    { 8, null, 1, 8, 1 },
                    { 9, null, 1, 9, 1 },
                    { 10, null, 1, 10, 1 },
                    { 11, null, 1, 11, 1 },
                    { 12, null, 1, 12, 1 },
                    { 13, null, 1, 13, 1 },
                    { 14, null, 1, 14, 1 },
                    { 15, null, 1, 15, 1 },
                    { 16, null, 1, 16, 1 },
                    { 17, null, 1, 17, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 18, null, 1, 18, 1 },
                    { 19, null, 1, 19, 1 },
                    { 81, null, 2, 1, 1 },
                    { 82, null, 2, 2, 1 },
                    { 84, null, 2, 4, 1 },
                    { 339, null, 5, 19, 1 },
                    { 169, null, 3, 9, 1 },
                    { 171, null, 3, 11, 1 },
                    { 257, null, 4, 17, 1 },
                    { 258, null, 4, 18, 1 },
                    { 259, null, 4, 19, 1 },
                    { 260, null, 4, 20, 1 },
                    { 321, null, 5, 1, 1 },
                    { 322, null, 5, 2, 1 },
                    { 323, null, 5, 3, 1 },
                    { 324, null, 5, 4, 1 },
                    { 325, null, 5, 5, 1 },
                    { 326, null, 5, 6, 1 },
                    { 327, null, 5, 7, 1 },
                    { 328, null, 5, 8, 1 },
                    { 329, null, 5, 9, 1 },
                    { 330, null, 5, 10, 1 },
                    { 331, null, 5, 11, 1 },
                    { 332, null, 5, 12, 1 },
                    { 333, null, 5, 13, 1 },
                    { 334, null, 5, 14, 1 },
                    { 335, null, 5, 15, 1 },
                    { 336, null, 5, 16, 1 },
                    { 337, null, 5, 17, 1 },
                    { 256, null, 4, 16, 1 },
                    { 170, null, 3, 10, 1 },
                    { 255, null, 4, 15, 1 },
                    { 253, null, 4, 13, 1 },
                    { 172, null, 3, 12, 1 },
                    { 173, null, 3, 13, 1 },
                    { 174, null, 3, 14, 1 },
                    { 175, null, 3, 15, 1 },
                    { 176, null, 3, 16, 1 },
                    { 177, null, 3, 17, 1 },
                    { 178, null, 3, 18, 1 },
                    { 179, null, 3, 19, 1 },
                    { 180, null, 3, 20, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 241, null, 4, 1, 1 },
                    { 242, null, 4, 2, 1 },
                    { 243, null, 4, 3, 1 },
                    { 244, null, 4, 4, 1 },
                    { 245, null, 4, 5, 1 },
                    { 246, null, 4, 6, 1 },
                    { 247, null, 4, 7, 1 },
                    { 248, null, 4, 8, 1 },
                    { 249, null, 4, 9, 1 },
                    { 250, null, 4, 10, 1 },
                    { 251, null, 4, 11, 1 },
                    { 252, null, 4, 12, 1 },
                    { 254, null, 4, 14, 1 },
                    { 760, null, 10, 20, 2 },
                    { 739, null, 10, 19, 1 },
                    { 22, null, 1, 2, 2 },
                    { 508, null, 7, 8, 2 },
                    { 509, null, 7, 9, 2 },
                    { 510, null, 7, 10, 2 },
                    { 511, null, 7, 11, 2 },
                    { 512, null, 7, 12, 2 },
                    { 513, null, 7, 13, 2 },
                    { 514, null, 7, 14, 2 },
                    { 515, null, 7, 15, 2 },
                    { 516, null, 7, 16, 2 },
                    { 517, null, 7, 17, 2 },
                    { 518, null, 7, 18, 2 },
                    { 519, null, 7, 19, 2 },
                    { 520, null, 7, 20, 2 },
                    { 581, null, 8, 1, 2 },
                    { 582, null, 8, 2, 2 },
                    { 583, null, 8, 3, 2 },
                    { 584, null, 8, 4, 2 },
                    { 585, null, 8, 5, 2 },
                    { 586, null, 8, 6, 2 },
                    { 587, null, 8, 7, 2 },
                    { 588, null, 8, 8, 2 },
                    { 507, null, 7, 7, 2 },
                    { 589, null, 8, 9, 2 },
                    { 506, null, 7, 6, 2 },
                    { 504, null, 7, 4, 2 },
                    { 423, null, 6, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 424, null, 6, 4, 2 },
                    { 425, null, 6, 5, 2 },
                    { 426, null, 6, 6, 2 },
                    { 427, null, 6, 7, 2 },
                    { 428, null, 6, 8, 2 },
                    { 429, null, 6, 9, 2 },
                    { 430, null, 6, 10, 2 },
                    { 431, null, 6, 11, 2 },
                    { 432, null, 6, 12, 2 },
                    { 433, null, 6, 13, 2 },
                    { 434, null, 6, 14, 2 },
                    { 435, null, 6, 15, 2 },
                    { 436, null, 6, 16, 2 },
                    { 437, null, 6, 17, 2 },
                    { 438, null, 6, 18, 2 },
                    { 439, null, 6, 19, 2 },
                    { 440, null, 6, 20, 2 },
                    { 501, null, 7, 1, 2 },
                    { 502, null, 7, 2, 2 },
                    { 503, null, 7, 3, 2 },
                    { 505, null, 7, 5, 2 },
                    { 422, null, 6, 2, 2 },
                    { 590, null, 8, 10, 2 },
                    { 592, null, 8, 12, 2 },
                    { 678, null, 9, 18, 2 },
                    { 679, null, 9, 19, 2 },
                    { 680, null, 9, 20, 2 },
                    { 741, null, 10, 1, 2 },
                    { 742, null, 10, 2, 2 },
                    { 743, null, 10, 3, 2 },
                    { 744, null, 10, 4, 2 },
                    { 745, null, 10, 5, 2 },
                    { 746, null, 10, 6, 2 },
                    { 747, null, 10, 7, 2 },
                    { 748, null, 10, 8, 2 },
                    { 749, null, 10, 9, 2 },
                    { 750, null, 10, 10, 2 },
                    { 751, null, 10, 11, 2 },
                    { 752, null, 10, 12, 2 },
                    { 753, null, 10, 13, 2 },
                    { 754, null, 10, 14, 2 },
                    { 755, null, 10, 15, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 756, null, 10, 16, 2 },
                    { 757, null, 10, 17, 2 },
                    { 758, null, 10, 18, 2 },
                    { 677, null, 9, 17, 2 },
                    { 591, null, 8, 11, 2 },
                    { 676, null, 9, 16, 2 },
                    { 674, null, 9, 14, 2 },
                    { 593, null, 8, 13, 2 },
                    { 594, null, 8, 14, 2 },
                    { 595, null, 8, 15, 2 },
                    { 596, null, 8, 16, 2 },
                    { 597, null, 8, 17, 2 },
                    { 598, null, 8, 18, 2 },
                    { 599, null, 8, 19, 2 },
                    { 600, null, 8, 20, 2 },
                    { 661, null, 9, 1, 2 },
                    { 662, null, 9, 2, 2 },
                    { 663, null, 9, 3, 2 },
                    { 664, null, 9, 4, 2 },
                    { 665, null, 9, 5, 2 },
                    { 666, null, 9, 6, 2 },
                    { 667, null, 9, 7, 2 },
                    { 668, null, 9, 8, 2 },
                    { 669, null, 9, 9, 2 },
                    { 670, null, 9, 10, 2 },
                    { 671, null, 9, 11, 2 },
                    { 672, null, 9, 12, 2 },
                    { 673, null, 9, 13, 2 },
                    { 675, null, 9, 15, 2 },
                    { 740, null, 10, 20, 1 },
                    { 421, null, 6, 1, 2 },
                    { 359, null, 5, 19, 2 },
                    { 108, null, 2, 8, 2 },
                    { 109, null, 2, 9, 2 },
                    { 110, null, 2, 10, 2 },
                    { 111, null, 2, 11, 2 },
                    { 112, null, 2, 12, 2 },
                    { 113, null, 2, 13, 2 },
                    { 114, null, 2, 14, 2 },
                    { 115, null, 2, 15, 2 },
                    { 116, null, 2, 16, 2 },
                    { 117, null, 2, 17, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 118, null, 2, 18, 2 },
                    { 119, null, 2, 19, 2 },
                    { 120, null, 2, 20, 2 },
                    { 181, null, 3, 1, 2 },
                    { 182, null, 3, 2, 2 },
                    { 183, null, 3, 3, 2 },
                    { 184, null, 3, 4, 2 },
                    { 185, null, 3, 5, 2 },
                    { 186, null, 3, 6, 2 },
                    { 187, null, 3, 7, 2 },
                    { 188, null, 3, 8, 2 },
                    { 107, null, 2, 7, 2 },
                    { 189, null, 3, 9, 2 },
                    { 106, null, 2, 6, 2 },
                    { 104, null, 2, 4, 2 },
                    { 23, null, 1, 3, 2 },
                    { 24, null, 1, 4, 2 },
                    { 25, null, 1, 5, 2 },
                    { 26, null, 1, 6, 2 },
                    { 27, null, 1, 7, 2 },
                    { 28, null, 1, 8, 2 },
                    { 29, null, 1, 9, 2 },
                    { 30, null, 1, 10, 2 },
                    { 31, null, 1, 11, 2 },
                    { 32, null, 1, 12, 2 },
                    { 33, null, 1, 13, 2 },
                    { 34, null, 1, 14, 2 },
                    { 35, null, 1, 15, 2 },
                    { 36, null, 1, 16, 2 },
                    { 37, null, 1, 17, 2 },
                    { 38, null, 1, 18, 2 },
                    { 39, null, 1, 19, 2 },
                    { 40, null, 1, 20, 2 },
                    { 101, null, 2, 1, 2 },
                    { 102, null, 2, 2, 2 },
                    { 103, null, 2, 3, 2 },
                    { 105, null, 2, 5, 2 },
                    { 360, null, 5, 20, 2 },
                    { 190, null, 3, 10, 2 },
                    { 192, null, 3, 12, 2 },
                    { 278, null, 4, 18, 2 },
                    { 279, null, 4, 19, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 280, null, 4, 20, 2 },
                    { 341, null, 5, 1, 2 },
                    { 342, null, 5, 2, 2 },
                    { 343, null, 5, 3, 2 },
                    { 344, null, 5, 4, 2 },
                    { 345, null, 5, 5, 2 },
                    { 346, null, 5, 6, 2 },
                    { 347, null, 5, 7, 2 },
                    { 348, null, 5, 8, 2 },
                    { 349, null, 5, 9, 2 },
                    { 350, null, 5, 10, 2 },
                    { 351, null, 5, 11, 2 },
                    { 352, null, 5, 12, 2 },
                    { 353, null, 5, 13, 2 },
                    { 354, null, 5, 14, 2 },
                    { 355, null, 5, 15, 2 },
                    { 356, null, 5, 16, 2 },
                    { 357, null, 5, 17, 2 },
                    { 358, null, 5, 18, 2 },
                    { 277, null, 4, 17, 2 },
                    { 191, null, 3, 11, 2 },
                    { 276, null, 4, 16, 2 },
                    { 274, null, 4, 14, 2 },
                    { 193, null, 3, 13, 2 },
                    { 194, null, 3, 14, 2 },
                    { 195, null, 3, 15, 2 },
                    { 196, null, 3, 16, 2 },
                    { 197, null, 3, 17, 2 },
                    { 198, null, 3, 18, 2 },
                    { 199, null, 3, 19, 2 },
                    { 200, null, 3, 20, 2 },
                    { 261, null, 4, 1, 2 },
                    { 262, null, 4, 2, 2 },
                    { 263, null, 4, 3, 2 },
                    { 264, null, 4, 4, 2 },
                    { 265, null, 4, 5, 2 },
                    { 266, null, 4, 6, 2 },
                    { 267, null, 4, 7, 2 },
                    { 268, null, 4, 8, 2 },
                    { 269, null, 4, 9, 2 },
                    { 270, null, 4, 10, 2 },
                    { 271, null, 4, 11, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[,]
                {
                    { 272, null, 4, 12, 2 },
                    { 273, null, 4, 13, 2 },
                    { 275, null, 4, 15, 2 },
                    { 800, null, 10, 20, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[] { 20, 1, 1, 20, 1 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookingId", "RoomId", "SeatNumber", "ShowTimeId" },
                values: new object[] { 21, 1, 1, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_MovieId",
                table: "Bookings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PhoneNumber",
                table: "Customers",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BookingId",
                table: "Tickets",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_RoomId",
                table: "Tickets",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ShowTimeId",
                table: "Tickets",
                column: "ShowTimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "ShowTimes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
