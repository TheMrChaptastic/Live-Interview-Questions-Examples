using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests.Stage_1_Tests
{
    public class ReverseAStringTests
    {
        private QReverseAString _reverseString = new QReverseAString();

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ShouldBeEmpty(string str)
        {
            var result = _reverseString.ReverseString(str);

            Assert.AreEqual("", result);
        }
        [Test]
        [TestCase("test","tset")]
        [TestCase("another one","eno rehtona")]
        [TestCase("Chicken", "nekcihC")]
        [TestCase("winner", "renniw")]
        [TestCase("We're no strangers to love You know the rules and so do I A full commitment's what I'm thinking of You wouldn't get this from any other guy I just wanna tell you how I'm feeling Gotta make you understand Never gonna give you up Never gonna let you down Never gonna run around and desert you Never gonna make you cry Never gonna say goodbye Never gonna tell a lie and hurt you We've known each other for so long Your heart's been aching, but you're too shy to say it Inside, we both know what's been going on We know the game, and we're gonna play it And if you ask me how I'm feeling Don't tell me you're too blind to see Never gonna give you up Never gonna let you down Never gonna run around and desert you Never gonna make you cry Never gonna say goodbye Never gonna tell a lie and hurt you Never gonna give you up Never gonna let you down Never gonna run around and desert you Never gonna make you cry Never gonna say goodbye Never gonna tell a lie and hurt you Ooh (Give you up) Ooh-ooh (Give you up) Ooh-ooh Never gonna give, never gonna give (Give you up) Ooh-ooh Never gonna give, never gonna give (Give you up) We've known each other for so long Your heart's been aching, but you're too shy to say it Inside, we both know what's been going on We know the game, and we're gonna play it I just wanna tell you how I'm feeling Gotta make you understand Never gonna give you up Never gonna let you down Never gonna run around and desert you Never gonna make you cry Never gonna say goodbye Never gonna tell a lie and hurt you Never gonna give you up Never gonna let you down Never gonna run around and desert you Never gonna make you cry Never gonna say goodbye Never gonna tell a lie and hurt you Never gonna give you up Never gonna let you down Never gonna run around and desert you Never gonna make you cry Never gonna say goodbye Never gonna tell a lie and hurt you", "uoy truh dna eil a llet annog reveN eybdoog yas annog reveN yrc uoy ekam annog reveN uoy tresed dna dnuora nur annog reveN nwod uoy tel annog reveN pu uoy evig annog reveN uoy truh dna eil a llet annog reveN eybdoog yas annog reveN yrc uoy ekam annog reveN uoy tresed dna dnuora nur annog reveN nwod uoy tel annog reveN pu uoy evig annog reveN uoy truh dna eil a llet annog reveN eybdoog yas annog reveN yrc uoy ekam annog reveN uoy tresed dna dnuora nur annog reveN nwod uoy tel annog reveN pu uoy evig annog reveN dnatsrednu uoy ekam attoG gnileef m'I woh uoy llet annaw tsuj I ti yalp annog er'ew dna ,emag eht wonk eW no gniog neeb s'tahw wonk htob ew ,edisnI ti yas ot yhs oot er'uoy tub ,gnihca neeb s'traeh ruoY gnol os rof rehto hcae nwonk ev'eW )pu uoy eviG( evig annog reven ,evig annog reveN hoo-hoO )pu uoy eviG( evig annog reven ,evig annog reveN hoo-hoO )pu uoy eviG( hoo-hoO )pu uoy eviG( hoO uoy truh dna eil a llet annog reveN eybdoog yas annog reveN yrc uoy ekam annog reveN uoy tresed dna dnuora nur annog reveN nwod uoy tel annog reveN pu uoy evig annog reveN uoy truh dna eil a llet annog reveN eybdoog yas annog reveN yrc uoy ekam annog reveN uoy tresed dna dnuora nur annog reveN nwod uoy tel annog reveN pu uoy evig annog reveN ees ot dnilb oot er'uoy em llet t'noD gnileef m'I woh em ksa uoy fi dnA ti yalp annog er'ew dna ,emag eht wonk eW no gniog neeb s'tahw wonk htob ew ,edisnI ti yas ot yhs oot er'uoy tub ,gnihca neeb s'traeh ruoY gnol os rof rehto hcae nwonk ev'eW uoy truh dna eil a llet annog reveN eybdoog yas annog reveN yrc uoy ekam annog reveN uoy tresed dna dnuora nur annog reveN nwod uoy tel annog reveN pu uoy evig annog reveN dnatsrednu uoy ekam attoG gnileef m'I woh uoy llet annaw tsuj I yug rehto yna morf siht teg t'ndluow uoY fo gnikniht m'I tahw s'tnemtimmoc lluf A I od os dna selur eht wonk uoY evol ot sregnarts on er'eW")]
        public void ShouldBeReversed(string str, string expected)
        {
            var result = _reverseString.ReverseString(str);

            Assert.AreEqual(expected, result);
        }
    }
}
