import React, { useState } from 'react';

export function Home() {
  var [cepResponse, setCepResponse] = useState("{}");
  var cepRef = React.createRef();

  async function buscaCEP(cep) {
    const response = await fetch(`https://viacep.com.br/ws/${cep}/json/`);
    const data = await response.text();
    setCepResponse(data.replace("cep", "CepString").replace("-", ""));
  }

  async function gravaCEP(cepObj) {
    const response = await fetch("/api/record", {
      method: "POST",
      headers: {
        "Content-Type": "application/json"
      },
      body: cepObj
    })
    .then(response => response.json())
    .then(data => console.log(data));
  }

  async function recuperaCEP(cep) {
    const response = await fetch(`/api/record?cep=${cep}`);
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
      <button className="btn btn-secondary" onClick={(e) => gravaCEP(cepResponse)}>
        Persistir Dados
      </button>
      <button className="btn btn-secondary" onClick={(e) => recuperaCEP(cepRef.current.value)}>
        Consultar DB
      </button>
      <div id="result-block" style={{overflowWrap: "break-word"}}>
        {cepResponse.replace("CepString", "cep")}
      </div>
    </div>
  );
}
