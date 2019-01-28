"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var PersonConsumer = /** @class */ (function () {
    function PersonConsumer(httpClient) {
        this.httpClient = httpClient;
        this.apiURL = 'http://http://localhost:59714/api/';
    }
    PersonConsumer.prototype.getPerson = function () {
        return this.httpClient.get(this.apiURL + "/person");
    };
    return PersonConsumer;
}());
exports.PersonConsumer = PersonConsumer;
//# sourceMappingURL=person.js.map