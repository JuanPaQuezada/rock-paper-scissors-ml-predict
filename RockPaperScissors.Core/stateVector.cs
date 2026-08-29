using Microsoft.CSharp.RuntimeBinder;

namespace RockPaperScissors.Core;

public class stateVector
{
    private int _capacidadDatos;
    private readonly int[] _vector;
    
    int cabezalVector=0;
    int contador_jugadas=0;
    

    public stateVector(int capacidadDatos)
    {
        _capacidadDatos = capacidadDatos;
        _vector = new int[_capacidadDatos];
        cabezalVector = 0;
        contador_jugadas = 0;
    }

    public bool IsReadyForInference()
    {
        if (contador_jugadas>=3)
            return true;
        else
        {
            return false;
        }
    }

    public void RecordMove(int jugada)
    {
        if (contador_jugadas < _capacidadDatos)
        {
            contador_jugadas++;
        }
        _vector[cabezalVector] = jugada;
        cabezalVector = (cabezalVector + 1) % _capacidadDatos;
    }

    public string GetSerializedHistory()
    {
        string sep = ", ";
        int origen_tiempo = 0;
        int[] history_vector=new int[contador_jugadas];
        if (contador_jugadas < _capacidadDatos)
        {
            origen_tiempo = 0;
        } else if (contador_jugadas == _capacidadDatos)
        {
            origen_tiempo = cabezalVector;
        }

        for (int i = 0; i < contador_jugadas; i++)
        {
            int indice_extraer_jugada=(origen_tiempo+i) % _capacidadDatos;
            history_vector[i] = _vector[indice_extraer_jugada];
        }

        return string.Join(sep, history_vector);
    }
    
}