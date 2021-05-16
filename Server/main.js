const WebSocket = require("ws");

const CoinServer = new WebSocket.Server({host: "127.0.0.1", port: 7777});
