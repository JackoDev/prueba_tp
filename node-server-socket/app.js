const app = require('express')();
const http = require('http').Server(app);
const io = require('socket.io')(http);

app.get('/', (req, res) => {
  res.send('Conectado al servidor')
});

// Config de los sockets

io.on('connection', (socket) => {
  console.log("Nuevo socket conectado");

  socket.on('Realizar peticion de serial', () => {
    console.log("Realizando Peticion");
    io.sockes.emit('')
  })
});

http.listen(5000, () => {
  console.log("Server listening on port 5000")
});


module.exports = app;
