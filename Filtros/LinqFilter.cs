﻿using ScreenSound_04.Modelos;
using System.Reflection.Metadata;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artista por gênero musical >>> {genero}");
        foreach(var  artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void ExibirMusicasComTonalidade(List<Musica> musicas, string Tonalidade)
    {
        var tonalidadeDaMusica = musicas.Where(musica => musica.Tonalidade == Tonalidade).ToList();
        foreach (var musica in tonalidadeDaMusica)
            Console.WriteLine("Musicas em C#: ");
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}
