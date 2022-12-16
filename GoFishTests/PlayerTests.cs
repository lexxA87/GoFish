using GoFish;

namespace GoFishTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void TestGetNextHand()
        {
            var player = new Player("Owen", new List<Card>());
            player.GetNextHand(new Deck());
            CollectionAssert.AreEqual(
                new Deck().Take(5).Select(card => card.ToString()).ToList(),
                player.Hand.Select(card => card.ToString()).ToList());
        }
        [TestMethod]
        public void TestDoYouHaveAny()
        {
            IEnumerable<Card> cards = new List<Card>()
            {
                new Card(Values.Jack, Suits.Spades),
                new Card(Values.Three, Suits.Clubs),
                new Card(Values.Three, Suits.Hearts),
                new Card(Values.Four, Suits.Diamonds),
                new Card(Values.Three, Suits.Diamonds),
                new Card(Values.Jack, Suits.Clubs),
            };
            var player = new Player("Owen", cards);

            var threes = player.DoYouHaveAny(Values.Three, new Deck())
                .Select(card => card.ToString())
                .ToList();

            CollectionAssert.AreEqual(new List<string>()
            {
                "Three of Clubs",
                "Three of Diamonds",
                "Three of Hearts",
            }, threes);

            Assert.AreEqual(3, player.Hand.Count());

            var jacks = player.DoYouHaveAny(Values.Jack, new Deck())
                .Select(card => card.ToString())
                .ToList();

            CollectionAssert.AreEqual(new List<string>()
            {
                "Jack of Clubs",
                "Jack of Spades",
            }, jacks);

            var hand = player.Hand.Select(card => card.ToString()).ToList();
            CollectionAssert.AreEqual(new List<string>() { "Four of Diamonds" }, hand);

            Assert.AreEqual("Owen has 1 card and 0 books", player.Status);
        }
    }
}