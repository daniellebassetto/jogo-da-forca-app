using JogoDaForcaApp.Models;

namespace JogoDaForcaApp.Repositories;

public class WordRepository
{
    private readonly List<Word> _words;
    public WordRepository()
    {
        _words =
        [
            new Word("Nome", "Maria".ToUpper()),
            new Word("Vegetal", "Cenoura".ToUpper()),
            new Word("Fruta", "Abacate".ToUpper()),
            new Word("Tempero", "Nordestino".ToUpper()),
            new Word("Tempero", "Baiano".ToUpper()),
        ];
    }

    public Word GetRandomWord()
    {
        Random rand = new();
        var number = rand.Next(0, _words.Count);
        return _words[number];
    }
}
