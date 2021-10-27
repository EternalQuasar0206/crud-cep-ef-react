import React, { useState } from 'react';

export function Home() {
  var [counter, setCounter] = useState(0);
  var [cepResponse, setCepResponse] = useState("{}");
  var cepRef = React.createRef();

  function addCounter() {
    setCounter(counter + 1);
  }

  async function buscaCEP(cep) {
    const response = await fetch(`https://viacep.com.br/ws/${cep}/json/`);
    const data = await response.text();
    setCepResponse(data);
  }
    return (
      <div>
        <h4>Insira seu CEP para continuar</h4>
        <input type="text" class="form-control" ref={cepRef}></input>
        <br />
        <button className="btn btn-primary" onClick={(e) => buscaCEP(cepRef.current.value)}>
          Consulta WebService ViaCep
        </button>
        <button className="btn btn-secondary">
          Persistir Dados
        </button>
        <button className="btn btn-secondary">
          Consultar DB
        </button>
        <div id="result-block">
          {cepResponse}
        </div>
      </div>
    );
}
