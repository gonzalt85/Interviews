import { InterviewsPage } from './app.po';

describe('interviews App', () => {
  let page: InterviewsPage;

  beforeEach(() => {
    page = new InterviewsPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
