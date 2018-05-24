#include <iostream>
#include <string>


using namespace std;

class Personagem
{
    private: string id;
    private: FILE sprites;


        public: Personagem(string P_id)
        {
            this->setId(P_id);
            this->abre_sprite();
        }

        private: void setId(string P_id) {this -> id = P_id;}

        private: void abre_sprite()
        {

        }

        private: void fecha_sprite()
        {

        }

        ///MÉTODOS DE AÇÃO



};

