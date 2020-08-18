const getHour = (hour) => {
	return hour <= 12 ? hour : hour - 12;
};

const getNumberAsText = (number) => {
	const table = {
		0: 'twelve',
		1: 'one',
		2: 'two',
		3: 'three',
		4: 'four',
		5: 'five',
		6: 'six',
		7: 'seven',
		8: 'eight',
		9: 'nine',
		10: 'ten',
		11: 'eleven',
		12: 'twelve',
		13: 'thirteen',
		14: 'fourteen',
		15: 'fifteen',
		16: 'sixteen',
		17: 'seventeen',
		18: 'eighteen',
		19: 'nineteen',
		20: 'twenty',
		21: 'twenty one',
		22: 'twenty two',
		23: 'twenty three',
		24: 'twenty four',
		25: 'twenty five',
		26: 'twenty six',
		27: 'twenty seven',
		28: 'twenty eight',
		29: 'twenty nine',
		30: 'thirty',
	};
	return table[parseInt(number)];
};

const getMinutesLabel = (minutes) => (minutes === 1 ? 'minute' : 'minutes');
const getMidnightLabel = (rawHour, target, hour) =>
	rawHour === target ? 'midnight' : getNumberAsText(hour);
const timeConverter = (time) => {
	const splatted = time.split(':');
	const rawHour = parseInt(splatted[0]);
	const hour = getHour(rawHour);
	const minutes = parseInt(splatted[1]);
	let rv = '';
	if (minutes == 0) {
		if (rawHour == 0) {
			rv = 'midnight';
		} else {
			rv = `${getNumberAsText(hour)} o'clock`;
		}
	} else if (minutes <= 30) {
		if (minutes === 15) {
			rv = `quarter past ${getMidnightLabel(rawHour, 0, hour)}`;
		} else if (minutes === 30) {
			rv = `half past ${getMidnightLabel(rawHour, 0, hour)}`;
		} else {
			rv = `${getNumberAsText(minutes)} ${getMinutesLabel(
				minutes
			)} past ${getMidnightLabel(rawHour, 0, hour)}`;
		}
	} else {
		rv = time;
		const timeLeft = 60 - minutes;
		const nextHour = hour + 1 == 13 ? 1 : hour + 1;
		if (timeLeft === 15) {
			rv = `quarter to ${getMidnightLabel(rawHour, 23, nextHour)}`;
		} else {
			rv = `${getNumberAsText(timeLeft)} ${getMinutesLabel(
				timeLeft
			)} to ${getMidnightLabel(rawHour, 23, nextHour)}`;
		}
	}
	return rv;
};

exports.timeConverter = timeConverter;
