var expect = require('chai').expect;

describe('Init', function(){

	it('starts a new test env', function(done){
		expect('test').to.equal('test');
		done();
	});
});