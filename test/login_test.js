var expect = require('chai').expect;
var app = require('../app');
var request = require('supertest');

var agent = request.agent(app);

describe('AuthCtrl /login', function(){
	it('should respond with 200 in case of successful login', function(done){
		agent.post('/login')
			.send()
			.end(function(err,res){
				if(err) {return done(err); }
				//console.log('res: ', res);
				var fetchedData = JSON.parse(res.text);
				//console.log('fetchedData: ', fetchedData);
				expect(fetchedData).to.be.an.instanceof(User);
				expect(fetchedData).to.not.empty;
				done();
			});
	});
});