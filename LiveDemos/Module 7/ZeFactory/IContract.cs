
namespace ZeFactory;

// De interface ontoppelt de interactie tussen objecten.
// Bevat alleen methods en properties (abstract), dus geen state (fields)
// De implentator is verplicht omm alle members van de interface te implementeren.
// De interface werkt tussen twee partijen: De provider en de consumer.
// De provider stelt de interface op en activeert de methodes.
// De consumer implementeert de interface.
// De interface beschrijft een can-do relatie.
interface IContract
{
    void Werkt();
}
