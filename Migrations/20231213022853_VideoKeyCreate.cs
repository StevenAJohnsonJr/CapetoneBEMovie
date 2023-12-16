using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaptoneBEMovie.Migrations
{
    public partial class VideoKeyCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoKey",
                table: "Movies",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoKey",
                value: "https://youtu.be/umvFBoLOOgo?si=yZ_P7ZDQ1Ph0SiOW ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoKey",
                value: "https://youtu.be/Uu7qV57UKSo?si=DkxMqaGL_Q1j-jeq ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoKey",
                value: "https://youtu.be/H3g5QQynaJk?si=FrGZVgY3lu6pmLnO ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoKey",
                value: "https://youtu.be/hL2q5hQWSMY?si=R6tc_ONl0IWoHP58 ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoKey",
                value: "https://youtu.be/jpyBrTSUO5k?si=nyMVRSUnq4dNMcIP ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "VideoKey" },
                values: new object[] { "Scott Calvin (Tim Allen) has been in the role of Santa for the past eight years, and hisdata:image/jpeg;base64,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 loyal elves consider him the best one ever. But the world of the \"Merry Old Soul\" turns upside down when he's dealt a double whammy of news: Not only has his son, Charlie (Eric Lloyd), landed on this year's naughty list, but Scott discovers that he must marry by Christmas Eve -- just a month away! -- or he will stop being Santa Claus forever.", "https://youtu.be/NML7Y1APyZs?si=mYhd3ZBcuh5Vf8Dh " });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoKey",
                value: "https://youtu.be/Bx8FX7etF_8?si=Ycpggl4n35gxeoZR");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoKey",
                value: "https://youtu.be/JDdS8qu11SA?si=H2qCTbU0RNeXzEgq ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "VideoKey",
                value: "https://youtu.be/B5h2xRYmANk?si=3-JQw7ie7O-p3OBk ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "VideoKey",
                value: "https://youtu.be/oj2lqpPtvBU?si=Y_QxgpMY3ckKt7bj ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "VideoKey",
                value: "https://youtu.be/oj2lqpPtvBU?si=Y_QxgpMY3ckKt7bj ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "VideoKey",
                value: "https://youtu.be/07pPmCfKi3U?si=EnBiVq3qVpmTdg1M ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "VideoKey",
                value: "https://youtu.be/HZokeJ_n-0c?si=5YhMfZJu3uojzFK_ ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "VideoKey",
                value: "https://youtu.be/4eaZ_48ZYog?si=KV9_HGAjc0d0IfbN ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "VideoKey",
                value: "https://youtu.be/BWZt4v6b1hI?si=AMoFxYVpn3oNc1nj ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "VideoKey",
                value: "https://youtu.be/3BEIhA8CcY0?si=_PogBBmQB_Vc5Aam ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "VideoKey",
                value: "https://youtu.be/cv01Mcdf8rI?si=CFtctBHVoD92Jn0M ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "VideoKey",
                value: "https://youtu.be/Yma-g4gTwlE?si=ii3sC8uDOh3EPJlO ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "VideoKey",
                value: "https://youtu.be/YnDeJn-BX5Q?si=AwXLEbAmSq-Gpcql ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "VideoKey",
                value: "https://youtu.be/zPXqwAGmX04?si=fZG406l363DpMEur ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "VideoKey",
                value: "https://youtu.be/RDm_jsvksQQ?si=G6MNLnCkxhRntTiu ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "VideoKey",
                value: "https://youtu.be/kL5c2szf3E4?si=AQIXCzkQq10XH8_U ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "VideoKey",
                value: "https://youtu.be/uldqs2kW25g?si=TTMzHzm63HsbLfHG ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DirectorId", "GenreId", "VideoKey" },
                values: new object[] { 20, 1, "https://youtu.be/CewglxElBK0?si=W8Rb9_L3V1aafnB2 " });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Title", "VideoKey" },
                values: new object[] { "American Pie", "https://youtu.be/iUZ3Yxok6N8?si=fxNKBrZ2EIITq2fH " });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "VideoKey",
                value: "https://youtu.be/PyVEHIO6jZ0?si=EVpck3umz1k9LaOl ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "VideoKey",
                value: "https://youtu.be/S0Mb6BgnhS0?si=QQMEFlt42GrSups4 ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "VideoKey",
                value: "https://youtu.be/ekF2wGDqu84?si=PLrl4oXvmhwbMAfP ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "VideoKey",
                value: "https://youtu.be/Nadp60OP4D4?si=0EbJ-ZO_9vbmtTBE ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "VideoKey",
                value: "https://youtu.be/frsvWVEHowg?si=81l4Su1LsA3UMjCY ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "VideoKey",
                value: "https://youtu.be/N_YrFMAEKKA?si=H8fRS38G3S9RGH5w ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "VideoKey",
                value: "https://youtu.be/Y21ElFK5YKw?si=1dUsTcBRETbsEHoL ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "VideoKey",
                value: "https://youtu.be/RLoKtb4c4W0?si=C0Y7NQp-tgFRqcDy ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "VideoKey",
                value: "https://youtu.be/JgacDwgKiZg?si=3PCrXxinLOgAWzDg ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "VideoKey",
                value: "https://youtu.be/A2tPgGiBvkc?si=0zeu8KTAuBDfrXNq ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "VideoKey",
                value: "https://youtu.be/tcdUhdOlz9M?si=RLAs9jSZHlF35fof ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "VideoKey",
                value: "https://youtu.be/ohF5ZO_zOYU?si=oAuKX8PRZoLNPhLl ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "VideoKey",
                value: "https://youtu.be/NKE-RXR_XIs?si=IqE2CddS49fr1Spt ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "VideoKey",
                value: "https://youtu.be/GncQtURdcE4?si=B8Q1c6OYQmuAy865 ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "VideoKey",
                value: "https://youtu.be/l13yPhimE3o?si=8VNfXaSkNA5XdP2D ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "VideoKey",
                value: "https://youtu.be/tdjX8Voj5vI?si=1H1BdVonzDvbdDzW ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "VideoKey",
                value: "https://youtu.be/dmNddThxi4c?si=7JFXc7JJoG90HGLO ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 101,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 102,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 103,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 104,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 105,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 106,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 107,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 108,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 109,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 110,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 111,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 112,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 113,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 114,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 115,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 116,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 117,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 118,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 119,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 120,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 121,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 122,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 123,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 124,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 125,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 126,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 127,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 128,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 129,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 130,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 131,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 132,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 133,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 134,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 135,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 136,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 137,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 138,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 139,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 140,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 141,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 142,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 143,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 144,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 145,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 146,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 147,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 148,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 149,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 150,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 151,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 152,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 153,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 154,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 155,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 156,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 157,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 158,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 159,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 160,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 161,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 162,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 163,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 164,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 165,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 166,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 167,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 168,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 169,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 170,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 171,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 172,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 173,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 174,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 175,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 176,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 177,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 178,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 179,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 180,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 181,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 182,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 183,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 184,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 185,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 186,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 187,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 188,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 189,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 190,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 191,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 192,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 193,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 194,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 195,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 196,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 197,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 198,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 199,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 200,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 201,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 202,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 203,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 204,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 205,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 206,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 207,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 208,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 209,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 210,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 211,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 212,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 213,
                column: "VideoKey",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 214,
                column: "VideoKey",
                value: " ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoKey",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Scott Calvin (Tim Allen) has been in the role of Santa for the past eight years, and his loyal elves consider him the best one ever. But the world of the \"Merry Old Soul\" turns upside down when he's dealt a double whammy of news: Not only has his son, Charlie (Eric Lloyd), landed on this year's naughty list, but Scott discovers that he must marry by Christmas Eve -- just a month away! -- or he will stop being Santa Claus forever.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DirectorId", "GenreId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "Title",
                value: "Friday");
        }
    }
}
