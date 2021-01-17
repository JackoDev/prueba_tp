const app = require('express')();
const http = require('http').Server(app);
const io = require('socket.io')(http);

app.get('/', (req, res) => {
  res.send('Conectado al servidor')
});


http.listen(5000, () => {
  console.log("Server listening on port 5000")
})


module.exports = app;
