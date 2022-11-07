
let contenedor = document.querySelector("#bodyDetalleProducto");


function detalleProducto(producto) {

	cargarVista("./Inventario/DetalleProducto/" + producto.id, "GET");

	$('#modalDetalleProducto').modal('show');
}

function eliminarProducto(producto) {
	$('#modalEliminarProducto').modal('show');
	document.getElementById("eliminarBtn").href = './Inventario/EliminarProducto/' + producto.id;
}

const cargarVista = (url, method) => {

	let xmlHttp = new XMLHttpRequest();

	xmlHttp.open(method, url);

	xmlHttp.onreadystatechange = (result) => {

		if (result.target.status === 200) {

			contenedor.innerHTML = result.srcElement.response;
			console.log(result.srcElement.response);
			result.preventDefault()
		}


	}

	xmlHttp.send();


}


