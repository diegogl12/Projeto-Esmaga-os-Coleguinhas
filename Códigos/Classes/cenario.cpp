#include <iostream>

using namespace  std;

class Cenario
{
    private: string id_plataforma;
    private: string id_fundo;

    public: Cenario(string P_id)
    {
        this->setId_fundo(P_id);
        this->setId_fundo(P_id);
    }

    private: void setId_plataforma(string P_id) {this->id_plataforma = P_id;}

    private: void setId_fundo(string P_id) {this->id_fundo = P_id;}

};
