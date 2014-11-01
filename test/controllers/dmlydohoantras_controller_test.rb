require 'test_helper'

class DmlydohoantrasControllerTest < ActionController::TestCase
  setup do
    @dmlydohoantra = dmlydohoantras(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmlydohoantras)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmlydohoantra" do
    assert_difference('Dmlydohoantra.count') do
      post :create, dmlydohoantra: { stt: @dmlydohoantra.stt, ten: @dmlydohoantra.ten }
    end

    assert_redirected_to dmlydohoantra_path(assigns(:dmlydohoantra))
  end

  test "should show dmlydohoantra" do
    get :show, id: @dmlydohoantra
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmlydohoantra
    assert_response :success
  end

  test "should update dmlydohoantra" do
    patch :update, id: @dmlydohoantra, dmlydohoantra: { stt: @dmlydohoantra.stt, ten: @dmlydohoantra.ten }
    assert_redirected_to dmlydohoantra_path(assigns(:dmlydohoantra))
  end

  test "should destroy dmlydohoantra" do
    assert_difference('Dmlydohoantra.count', -1) do
      delete :destroy, id: @dmlydohoantra
    end

    assert_redirected_to dmlydohoantras_path
  end
end
