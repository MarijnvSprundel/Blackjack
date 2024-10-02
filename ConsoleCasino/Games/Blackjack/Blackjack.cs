using ConsoleCasino.Games.Blackjack.Enums;
using ConsoleCasino.Games.Blackjack.Interfaces;
using ConsoleCasino.Games.Blackjack.Models;
using ConsoleCasino.Games.Blackjack.Services;
using ConsoleCasino.Interfaces;
using ConsoleCasino.Models;

namespace ConsoleCasino.Games.Blackjack;

public class Blackjack : IGame {
    private Deck _deck = new();
    private BlackjackDealer _dealer = new("Dealer");
    private BlackjackPlayer _player;

    public void Run(User user) {
        _player = new BlackjackPlayer(user);

        DrawCards();
        QuickInput();

        do {
            var input = AskInput(_player);

            HandleAction(input, _player);
        } while (_player.Cards() is { Busted: false, Stood: false, DoubledDown: false });

        RevealCard();

        while (_dealer.Cards().GetValue() < 17) HandleAction(BlackjackAction.Hit, _dealer);

        Summary();
    }

    private int InsertMoney(BlackjackPlayer player) {
        bool success = false;
        int amount;

        do {
            var text = player + " is now playing...\nPlace your bets";

            success = int.TryParse(Input(text, false), out amount);

            if (!success) QuickInput("Please enter a valid number.", false);
        } while (success == false);

        return amount;
    }

    private void DrawCards() {
        _deck.Shuffle();

        _dealer.CardSets.Add(new Cards([_deck.Draw(), _deck.Draw()]));
        _dealer.Cards()[1].Hidden = true;

        int value = InsertMoney(_player);
        _player.CardSets.Add(new Cards([_deck.Draw(), _deck.Draw()], value));
    }

    private BlackjackAction AskInput(BlackjackPlayer player) {
        string? input;

        do {
            input = Input(
                player + " is now playing...\nWhat would you like to do? Stand (S), Hit (H) or Double Down (D)?"
            )?.ToLower();

            if (input == "h" || input == "s" || input == "d") {
                break;
            }

            input = null;
        } while (input == null);

        return input switch {
            "h" => BlackjackAction.Hit,
            "s" => BlackjackAction.Stand,
            "d" => BlackjackAction.Double,
            _ => throw new ArgumentException("Invalid action: " + input)
        };
    }

    private void HandleAction(BlackjackAction action, BlackjackEntity entity) {
        switch (action) {
            case BlackjackAction.Stand:
                Stand(entity);
                break;
            case BlackjackAction.Hit:
                Hit(entity);
                break;
            case BlackjackAction.Double:
                DoubleDown(entity);
                break;
            default: throw new ArgumentException("You've broken it lmaoo");
        }

        CheckBust(entity);
    }

    private void Stand(BlackjackEntity entity) {
        entity.Cards().Stood = true;

        QuickInput(entity + " is now standing");
    }

    private void Hit(BlackjackEntity entity) {
        var card = _deck.Draw();
        entity.Cards().Add(card);

        QuickInput(entity + " drew and got a " + card);
    }

    private void DoubleDown(BlackjackEntity entity) {
        var card = _deck.Draw();
        entity.Cards().Add(card);
        entity.Cards().DoubledDown = true;

        QuickInput(entity + " doubled down and got a " + card);
    }

    private void CheckBust(BlackjackEntity entity) {
        if (entity.Cards().GetValue() <= 21) return;

        entity.Cards().Busted = true;

        QuickInput(entity + " has gone bust");
    }

    private void QuickInput(string? text = null, bool displayCards = true) {
        Console.Clear();

        if (displayCards) DisplayCards();

        if (text != null) Console.WriteLine(text + "\n");

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private string? Input(string text, bool displayCards = true) {
        Console.Clear();

        if (displayCards) DisplayCards();

        Console.WriteLine(text + "\n");
        return Console.ReadLine();
    }

    private void DisplayCards() {
        Console.WriteLine(_dealer + " has " + string.Join(", ", _dealer.Cards()));

        Console.WriteLine(_player + " has " + string.Join(", ", _player.Cards()) + " (value: " +
                          _player.Cards().GetValue() + ")\n");
    }

    private void RevealCard() {
        _dealer.Cards()[1].Hidden = false;

        QuickInput("Dealers second card was a " + _dealer.Cards()[1]);
    }

    private void Summary() {
        Console.Clear();

        DisplayCards();

        Console.WriteLine(_player + " has won " + BlackjackService.GetWinnings(_player.Cards(), _dealer.Cards()) +
                          " points");

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Blackjack explained
    // u get like two cards
    // dealer gets two cards
    // dealer has one card visible one card not
    // u can see your whole 2 cards
    // choose to stand/hit/double down
    // when you go above 21 you bust

    // when you have exactly 21 you just continue
    // below you can always hit
    // double down is only available on ur first turn i think
    // when you stand the dealer will start grabbing cards until they are above 17

    // ace has two values, 1 and 11. When 11 would make your value above 21 it becomes 1

    // so program is 
    // 1. start
    // 2. show cards of user and dealer
    // 3. let user decide
    // 4. if user is still under 21 and hasn't standed down yet let em do another choice
    // 5. make dealer start grabbing cards
    // 6. check if user or dealer has won

    // when we finish, add value system
    // Move code written here to seperate Blackjack class so we can also start on three card poker
    // then goo goo ga ga

    // Maybe split this fucking class up idk might be becoming large
    // also add values but the fucker is doing shit it isnt supposed to
    // like the fucker starts asking for money in the middle of the fucking game
    // retarded af that shit needs to be fixed
}

// ITS GOING DOWN IM YELLING TIMBEEEERRR