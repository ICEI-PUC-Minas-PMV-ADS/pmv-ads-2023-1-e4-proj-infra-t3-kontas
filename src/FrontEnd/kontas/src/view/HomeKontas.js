import React from "react";
import "../styles/HomeKontas.css";
import ListaContas from "./ListaContas";

function Cadastro() {
  return (
    <div className="home-box">
      <h1>Patrícia Knowles</h1>
      <div>
        <ListaContas />
      </div>
      <div>
        <button>Pagar</button>
      </div>
    </div>
  );
}

export default Cadastro;
