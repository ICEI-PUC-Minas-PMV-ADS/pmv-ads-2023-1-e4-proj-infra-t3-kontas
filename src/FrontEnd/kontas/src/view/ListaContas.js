import data from "../data.json";
import "../styles/ListaContas.css";

function ListaContas() {
  return (
    <div className="contas-a-pagar">
      <div className="contas-container">
        {data.map((conta, index) => (
          <div className="conta" key={index}>
            <h3>{conta.descricao}</h3>
            <p>R$ {conta.valor}</p>
            <p>{conta.dataVencimento}</p>
            <p
              className={
                conta.status === "Pendente" ? "status_a_pagar" : "status_pago"
              }
            >
              {conta.status}
            </p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default ListaContas;
