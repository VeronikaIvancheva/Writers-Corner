using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WritersCorner.Data.Migrations
{
    public partial class I : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Role = table.Column<string>(nullable: false),
                    RegisterOn = table.Column<DateTime>(nullable: true),
                    BansCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Birthday = table.Column<string>(nullable: true),
                    Death = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Nickname = table.Column<string>(nullable: true),
                    AthleticAbility = table.Column<string>(nullable: true),
                    SpecialAblilty = table.Column<string>(nullable: true),
                    LanguagesSpoken = table.Column<string>(nullable: true),
                    Background = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    FamilyInfo = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    EyeColor = table.Column<string>(nullable: true),
                    FaceShape = table.Column<string>(nullable: true),
                    FacialHair = table.Column<string>(nullable: true),
                    HairColor = table.Column<string>(nullable: true),
                    HairTexture = table.Column<string>(nullable: true),
                    SkinTone = table.Column<string>(nullable: true),
                    BodyType = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true),
                    Clothes = table.Column<string>(nullable: true),
                    Tatoos = table.Column<string>(nullable: true),
                    Piercing = table.Column<string>(nullable: true),
                    Birthmarks = table.Column<string>(nullable: true),
                    Scars = table.Column<string>(nullable: true),
                    Fears = table.Column<string>(nullable: true),
                    Vices = table.Column<string>(nullable: true),
                    Regrets = table.Column<string>(nullable: true),
                    Despise = table.Column<string>(nullable: true),
                    Motivation = table.Column<string>(nullable: true),
                    Goals = table.Column<string>(nullable: true),
                    AdmireOf = table.Column<string>(nullable: true),
                    InternalConflicts = table.Column<string>(nullable: true),
                    ExternalConflicts = table.Column<string>(nullable: true),
                    Race = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<string>(nullable: true),
                    Stratum = table.Column<string>(nullable: true),
                    Disabilities = table.Column<string>(nullable: true),
                    Personality = table.Column<string>(nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    Habits = table.Column<string>(nullable: true),
                    Odds = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true),
                    SkillsTheyLack = table.Column<string>(nullable: true),
                    EmotionalState = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Benefits = table.Column<string>(nullable: true),
                    History = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    Anathomy = table.Column<string>(nullable: true),
                    Breeds = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Kind = table.Column<string>(nullable: true),
                    Tamed = table.Column<string>(nullable: true),
                    Behavior = table.Column<string>(nullable: true),
                    Interaction = table.Column<string>(nullable: true),
                    Aggressiveness = table.Column<string>(nullable: true),
                    EnemyOf = table.Column<string>(nullable: true),
                    EnemyFor = table.Column<string>(nullable: true),
                    FriendOf = table.Column<string>(nullable: true),
                    FriendFor = table.Column<string>(nullable: true),
                    Rareness = table.Column<string>(nullable: true),
                    Speed = table.Column<string>(nullable: true),
                    Senses = table.Column<string>(nullable: true),
                    Lifespan = table.Column<string>(nullable: true),
                    Health = table.Column<string>(nullable: true),
                    Mythology = table.Column<string>(nullable: true),
                    Superstitions = table.Column<string>(nullable: true),
                    Rituals = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Rareness = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Desctiption = table.Column<string>(nullable: true),
                    History = table.Column<string>(nullable: true),
                    Travelling = table.Column<string>(nullable: true),
                    Environment = table.Column<string>(nullable: true),
                    CreationOn = table.Column<string>(nullable: true),
                    Resources = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Rulers = table.Column<string>(nullable: true),
                    Flaws = table.Column<string>(nullable: true),
                    Merits = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    SituatedIn = table.Column<string>(nullable: true),
                    BargainingChip = table.Column<string>(nullable: true),
                    Clothes = table.Column<string>(nullable: true),
                    Languages = table.Column<string>(nullable: true),
                    Dialects = table.Column<string>(nullable: true),
                    Asscents = table.Column<string>(nullable: true),
                    Trading = table.Column<string>(nullable: true),
                    Food = table.Column<string>(nullable: true),
                    FoodObtainingWays = table.Column<string>(nullable: true),
                    Art = table.Column<string>(nullable: true),
                    Holidays = table.Column<string>(nullable: true),
                    Entertainments = table.Column<string>(nullable: true),
                    Culture = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Cults = table.Column<string>(nullable: true),
                    Rituals = table.Column<string>(nullable: true),
                    Wars = table.Column<string>(nullable: true),
                    Unions = table.Column<string>(nullable: true),
                    Fears = table.Column<string>(nullable: true),
                    Military = table.Column<string>(nullable: true),
                    Weapons = table.Column<string>(nullable: true),
                    Training = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Punishments = table.Column<string>(nullable: true),
                    Characteristics = table.Column<string>(nullable: true),
                    EmotionalState = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stratums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Desctiption = table.Column<string>(nullable: true),
                    History = table.Column<string>(nullable: true),
                    Travelling = table.Column<string>(nullable: true),
                    Environment = table.Column<string>(nullable: true),
                    CreationOn = table.Column<string>(nullable: true),
                    Resources = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Rulers = table.Column<string>(nullable: true),
                    Flaws = table.Column<string>(nullable: true),
                    Merits = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    SituatedIn = table.Column<string>(nullable: true),
                    BargainingChip = table.Column<string>(nullable: true),
                    Clothes = table.Column<string>(nullable: true),
                    Languages = table.Column<string>(nullable: true),
                    Dialects = table.Column<string>(nullable: true),
                    Asscents = table.Column<string>(nullable: true),
                    Trading = table.Column<string>(nullable: true),
                    Food = table.Column<string>(nullable: true),
                    FoodObtainingWays = table.Column<string>(nullable: true),
                    Art = table.Column<string>(nullable: true),
                    Holidays = table.Column<string>(nullable: true),
                    Entertainments = table.Column<string>(nullable: true),
                    Culture = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Cults = table.Column<string>(nullable: true),
                    Rituals = table.Column<string>(nullable: true),
                    Wars = table.Column<string>(nullable: true),
                    Unions = table.Column<string>(nullable: true),
                    Fears = table.Column<string>(nullable: true),
                    Military = table.Column<string>(nullable: true),
                    Weapons = table.Column<string>(nullable: true),
                    Training = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Punishments = table.Column<string>(nullable: true),
                    Characteristics = table.Column<string>(nullable: true),
                    EmotionalState = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stratums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Structures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Rareness = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Structures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Timelines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timelines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Worlds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    CreationOn = table.Column<string>(nullable: true),
                    Resources = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Rulers = table.Column<string>(nullable: true),
                    Flaws = table.Column<string>(nullable: true),
                    Merits = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    SituatedIn = table.Column<string>(nullable: true),
                    BargainingChip = table.Column<string>(nullable: true),
                    Clothes = table.Column<string>(nullable: true),
                    Punishments = table.Column<string>(nullable: true),
                    Characteristics = table.Column<string>(nullable: true),
                    EmotionalState = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worlds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SiteInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUs = table.Column<string>(nullable: true),
                    AboutUs = table.Column<string>(nullable: true),
                    FAQ = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteInfos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookCharacters",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCharacters", x => new { x.BookId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_BookCharacters_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCharacters_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCreatures",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    CreatureId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCreatures", x => new { x.BookId, x.CreatureId });
                    table.ForeignKey(
                        name: "FK_BookCreatures_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCreatures_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookItems",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookItems", x => new { x.BookId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_BookItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookPlaces",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    PlaceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookPlaces", x => new { x.BookId, x.PlaceId });
                    table.ForeignKey(
                        name: "FK_BookPlaces_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookPlaces_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookStratums",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    StratumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStratums", x => new { x.BookId, x.StratumId });
                    table.ForeignKey(
                        name: "FK_BookStratums_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookStratums_Stratums_StratumId",
                        column: x => x.StratumId,
                        principalTable: "Stratums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookStructures",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    StructureId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStructures", x => new { x.BookId, x.StructureId });
                    table.ForeignKey(
                        name: "FK_BookStructures_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookStructures_Structures_StructureId",
                        column: x => x.StructureId,
                        principalTable: "Structures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookTimelines",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    TimelineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTimelines", x => new { x.BookId, x.TimelineId });
                    table.ForeignKey(
                        name: "FK_BookTimelines_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookTimelines_Timelines_TimelineId",
                        column: x => x.TimelineId,
                        principalTable: "Timelines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookWorlds",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    WorldId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookWorlds", x => new { x.BookId, x.WorldId });
                    table.ForeignKey(
                        name: "FK_BookWorlds_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookWorlds_Worlds_WorldId",
                        column: x => x.WorldId,
                        principalTable: "Worlds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_BookCharacters_CharacterId",
                table: "BookCharacters",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCreatures_CreatureId",
                table: "BookCreatures",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_BookItems_ItemId",
                table: "BookItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPlaces_PlaceId",
                table: "BookPlaces",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookStratums_StratumId",
                table: "BookStratums",
                column: "StratumId");

            migrationBuilder.CreateIndex(
                name: "IX_BookStructures_StructureId",
                table: "BookStructures",
                column: "StructureId");

            migrationBuilder.CreateIndex(
                name: "IX_BookTimelines_TimelineId",
                table: "BookTimelines",
                column: "TimelineId");

            migrationBuilder.CreateIndex(
                name: "IX_BookWorlds_WorldId",
                table: "BookWorlds",
                column: "WorldId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteInfos_UserId",
                table: "SiteInfos",
                column: "UserId");
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
                name: "BookCharacters");

            migrationBuilder.DropTable(
                name: "BookCreatures");

            migrationBuilder.DropTable(
                name: "BookItems");

            migrationBuilder.DropTable(
                name: "BookPlaces");

            migrationBuilder.DropTable(
                name: "BookStratums");

            migrationBuilder.DropTable(
                name: "BookStructures");

            migrationBuilder.DropTable(
                name: "BookTimelines");

            migrationBuilder.DropTable(
                name: "BookWorlds");

            migrationBuilder.DropTable(
                name: "SiteInfos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Creatures");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Stratums");

            migrationBuilder.DropTable(
                name: "Structures");

            migrationBuilder.DropTable(
                name: "Timelines");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Worlds");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
