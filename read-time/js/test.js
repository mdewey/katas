const assert = require('assert');

const { timeConverter } = require('./index');

describe('time', function () {
	it('basic', function () {
		assert.equal(timeConverter('13:00'), "one o'clock");
		assert.equal(timeConverter('13:09'), 'nine minutes past one');
		assert.equal(timeConverter('13:15'), 'quarter past one');
		assert.equal(timeConverter('13:29'), 'twenty nine minutes past one');
		assert.equal(timeConverter('13:30'), 'half past one');
		assert.equal(timeConverter('13:31'), 'twenty nine minutes to two');
		assert.equal(timeConverter('13:45'), 'quarter to two');
		assert.equal(timeConverter('13:59'), 'one minute to two');
		assert.equal(timeConverter('00:48'), 'twelve minutes to one');
		assert.equal(timeConverter('00:08'), 'eight minutes past midnight');
		assert.equal(timeConverter('12:00'), "twelve o'clock");
		assert.equal(timeConverter('00:00'), 'midnight');
		assert.equal(timeConverter('19:01'), 'one minute past seven');
		assert.equal(timeConverter('07:01'), 'one minute past seven');
		assert.equal(timeConverter('01:59'), 'one minute to two');
		assert.equal(timeConverter('12:01'), 'one minute past twelve');
		assert.equal(timeConverter('00:01'), 'one minute past midnight');
		assert.equal(timeConverter('11:31'), 'twenty nine minutes to twelve');
		assert.equal(timeConverter('23:31'), 'twenty nine minutes to midnight');
		assert.equal(timeConverter('00:01'), 'one minute past midnight');
		assert.equal(timeConverter('11:45'), 'quarter to twelve');
		assert.equal(timeConverter('11:59'), 'one minute to twelve');
		assert.equal(timeConverter('23:45'), 'quarter to midnight');
		assert.equal(timeConverter('23:59'), 'one minute to midnight');
		assert.equal(timeConverter('01:45'), 'quarter to two');
		assert.equal(timeConverter('00:01'), 'one minute past midnight');
	});
});
